using System.Collections.Generic;

namespace Inovoice
{
    public class Invoice : IInvoice
    {
        public string NumberInvoice { get; set; } = "";
        public string NameInvoice { get; set; } = "";
        public string InnInvoice { get; set; } = "";
        public string DataInvoice { get; set; } = "";

        
        public List<IInvoiceItem> Items { get; set; } = new List<IInvoiceItem>();

        public void AddItem(IInvoiceItem item) => Items.Add(item);
        public void RemoveItem(IInvoiceItem item) => Items.Remove(item);
    }
}