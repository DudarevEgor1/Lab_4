using System.Collections.Generic;

namespace Inovoice
{
    public interface IInvoice
    {
        string NumberInvoice { get; set; }
        string NameInvoice { get; set; }
        string InnInvoice { get; set; }
        string DataInvoice { get; set; }
        List<IInvoiceItem> Items { get; set; }

        void AddItem(IInvoiceItem item);
        void RemoveItem(IInvoiceItem item);
    }
}