namespace Inovoice
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.dgvItems = new System.Windows.Forms.DataGridView();

           
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtInn = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();

           
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtItemSum = new System.Windows.Forms.TextBox();
            this.txtItemNds = new System.Windows.Forms.TextBox();

        
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.btnEditInvoice = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();

         
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();

           
            this.lblInvoices = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();

            
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Location = new System.Drawing.Point(12, 60);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.Size = new System.Drawing.Size(860, 150);
            this.dgvInvoices.TabIndex = 0;
            this.dgvInvoices.SelectionChanged += new System.EventHandler(this.dgvInvoices_SelectionChanged);

        
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(12, 310);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(860, 200);
            this.dgvItems.TabIndex = 1;
            this.dgvItems.SelectionChanged += new System.EventHandler(this.dgvItems_SelectionChanged);

      
   

            this.txtNum.Location = new System.Drawing.Point(12, 12);
            this.txtNum.Name = "txtNum";
            this.txtNum.PlaceholderText = "№ Счета";
            this.txtNum.Size = new System.Drawing.Size(100, 23);

            this.txtSupplier.Location = new System.Drawing.Point(120, 12);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.PlaceholderText = "Поставщик";
            this.txtSupplier.Size = new System.Drawing.Size(150, 23);

            this.txtInn.Location = new System.Drawing.Point(280, 12);
            this.txtInn.Name = "txtInn";
            this.txtInn.PlaceholderText = "ИНН";
            this.txtInn.Size = new System.Drawing.Size(120, 23);

            this.btnSaveInvoice.Location = new System.Drawing.Point(420, 11);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(120, 25);
            this.btnSaveInvoice.Text = "Добавить Счет";
            this.btnSaveInvoice.UseVisualStyleBackColor = true;
            this.btnSaveInvoice.Click += new System.EventHandler(this.btnSaveInvoice_Click);

            this.btnEditInvoice.Location = new System.Drawing.Point(550, 11);
            this.btnEditInvoice.Name = "btnEditInvoice";
            this.btnEditInvoice.Size = new System.Drawing.Size(120, 25);
            this.btnEditInvoice.Text = "Изменить Счет";
            this.btnEditInvoice.UseVisualStyleBackColor = true;
            this.btnEditInvoice.Click += new System.EventHandler(this.btnEditInvoice_Click);

            this.btnDeleteInvoice.Location = new System.Drawing.Point(680, 11);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(120, 25);
            this.btnDeleteInvoice.Text = "Удалить Счет";
            this.btnDeleteInvoice.UseVisualStyleBackColor = true;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);

            this.lblInvoices.AutoSize = true;
            this.lblInvoices.Location = new System.Drawing.Point(12, 42);
            this.lblInvoices.Name = "lblInvoices";
            this.lblInvoices.Text = "Реестр счетов-фактур:";



            this.txtItemName.Location = new System.Drawing.Point(12, 250);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PlaceholderText = "Название товара";
            this.txtItemName.Size = new System.Drawing.Size(200, 23);

            this.txtUnit.Location = new System.Drawing.Point(220, 250);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.PlaceholderText = "Ед. изм.";
            this.txtUnit.Size = new System.Drawing.Size(80, 23);

            this.txtItemSum.Location = new System.Drawing.Point(310, 250);
            this.txtItemSum.Name = "txtItemSum";
            this.txtItemSum.PlaceholderText = "Сумма без НДС";
            this.txtItemSum.Size = new System.Drawing.Size(100, 23);

            this.txtItemNds.Location = new System.Drawing.Point(420, 250);
            this.txtItemNds.Name = "txtItemNds";
            this.txtItemNds.PlaceholderText = "НДС (%)";
            this.txtItemNds.Size = new System.Drawing.Size(80, 23);

            this.btnAddItem.Location = new System.Drawing.Point(520, 249);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(110, 25);
            this.btnAddItem.Text = "Добавить товар";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);

            this.btnEditItem.Location = new System.Drawing.Point(640, 249);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(110, 25);
            this.btnEditItem.Text = "Изменить товар";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);

            this.btnRemoveItem.Location = new System.Drawing.Point(760, 249);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(110, 25);
            this.btnRemoveItem.Text = "Удалить товар";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);

            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(12, 292);
            this.lblItems.Name = "lblItems";
            this.lblItems.Text = "Товары выбранного счета:";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 531);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.lblInvoices);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnEditItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnDeleteInvoice);
            this.Controls.Add(this.btnEditInvoice);
            this.Controls.Add(this.btnSaveInvoice);
            this.Controls.Add(this.txtItemNds);
            this.Controls.Add(this.txtItemSum);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtInn);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.dgvInvoices);
            this.Name = "Form1";
            this.Text = "Учет счетов-фактур";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtInn;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtItemSum;
        private System.Windows.Forms.TextBox txtItemNds;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.Button btnEditInvoice;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Label lblInvoices;
        private System.Windows.Forms.Label lblItems;
    }
}