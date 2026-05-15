namespace Interfaces
{
    public interface IInvoice
    {
        public string NameInvoice { get; set; }
        public string InnInvoice { get; set; }
        public string NumberInvoice { get; set; }
        public string DataInvoice { get; set; }
        public string Description { get; set; }

        double TotalAmount { get; }

        void AddItem(IInvoiceItem item);
        void RemoveItem(IInvoiceItem item);
        double CalculateAmount();
        List<IInvoiceItem> Items { get; }


    }
}
