using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Inovoice
{
    public partial class Form1 : Form
    {
        private List<IInvoice> _allInvoices = new List<IInvoice>();
        private IInvoice _draftInvoice = new Invoice(); 
        private bool _isUpdating = false;

        public Form1()
        {
            InitializeComponent();
            ConfigureGrids();
        }

        private void ConfigureGrids()
        {
            dgvInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoices.MultiSelect = false;
            dgvInvoices.ReadOnly = true;

            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.MultiSelect = false;
            dgvItems.ReadOnly = true;
        }

      

        private void dgvInvoices_SelectionChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;

            if (dgvInvoices.CurrentRow != null && dgvInvoices.CurrentRow.Index >= 0)
            {
                var selected = dgvInvoices.CurrentRow.DataBoundItem as IInvoice;
                if (selected != null)
                {
                  
                    txtNum.Text = selected.NumberInvoice;
                    txtSupplier.Text = selected.NameInvoice;
                    txtInn.Text = selected.InnInvoice;

                   
                    RefreshItemsGrid(selected.Items);
                }
            }
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {

            var newInvoice = new Invoice
            {
                NumberInvoice = txtNum.Text,
                NameInvoice = txtSupplier.Text,
                InnInvoice = txtInn.Text,
                DataInvoice = DateTime.Now.ToShortDateString(),
                Items = new List<IInvoiceItem>(_draftInvoice.Items)
            };

            _allInvoices.Add(newInvoice);
            _draftInvoice.Items.Clear();

            RefreshInvoicesGrid();
            ClearInputs();
        }

        private void btnEditInvoice_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.CurrentRow?.DataBoundItem is IInvoice selected)
            {
                selected.NumberInvoice = txtNum.Text;
                selected.NameInvoice = txtSupplier.Text;
                selected.InnInvoice = txtInn.Text;
                RefreshInvoicesGrid();
            }
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.CurrentRow?.DataBoundItem is IInvoice selected)
            {
                _allInvoices.Remove(selected);
                RefreshInvoicesGrid();
                ClearInputs();
            }
        }

     

        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;

            if (dgvItems.CurrentRow?.DataBoundItem is IInvoiceItem item)
            {
                txtItemName.Text = item.NameItem;
                txtUnit.Text = item.UnitOfMeasurement;
                txtItemSum.Text = item.SumWithoutNDS.ToString();
                txtItemNds.Text = item.NDS.ToString();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                var newItem = new InvoiceItem
                {
                    NameItem = txtItemName.Text,
                    UnitOfMeasurement = txtUnit.Text,
                    SumWithoutNDS = double.Parse(txtItemSum.Text),
                    NDS = double.Parse(txtItemNds.Text)
                };

             
                if (dgvInvoices.SelectedRows.Count > 0)
                {
                    var selected = dgvInvoices.SelectedRows[0].DataBoundItem as IInvoice;
                    selected.AddItem(newItem);
                    RefreshItemsGrid(selected.Items);
                }
                else
                {
                    _draftInvoice.AddItem(newItem);
                    RefreshItemsGrid(_draftInvoice.Items);
                }
            }
            catch { MessageBox.Show("Ошибка в числах!"); }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow?.DataBoundItem is IInvoiceItem item)
            {
                item.NameItem = txtItemName.Text;
                item.UnitOfMeasurement = txtUnit.Text;
                item.SumWithoutNDS = double.Parse(txtItemSum.Text);
                item.NDS = double.Parse(txtItemNds.Text);

               
                var currentItems = dgvItems.DataSource as List<IInvoiceItem>;
                RefreshItemsGrid(currentItems);
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow?.DataBoundItem is IInvoiceItem item)
            {
                if (dgvInvoices.SelectedRows.Count > 0)
                    ((IInvoice)dgvInvoices.SelectedRows[0].DataBoundItem).RemoveItem(item);
                else
                    _draftInvoice.RemoveItem(item);

                var currentItems = dgvItems.DataSource as List<IInvoiceItem>;
                RefreshItemsGrid(currentItems);
            }
        }

      

        private void RefreshInvoicesGrid()
        {
            _isUpdating = true;
            dgvInvoices.DataSource = null;
            dgvInvoices.DataSource = _allInvoices;
            _isUpdating = false;
        }

        private void RefreshItemsGrid(List<IInvoiceItem> source)
        {
            _isUpdating = true;
            dgvItems.DataSource = null;
            dgvItems.DataSource = source;
            _isUpdating = false;
        }

        private void ClearInputs()
        {
            txtNum.Clear(); txtSupplier.Clear(); txtInn.Clear();
            txtItemName.Clear(); txtUnit.Clear(); txtItemSum.Clear(); txtItemNds.Clear();
        }
    }
}