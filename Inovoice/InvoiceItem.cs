namespace Inovoice
{
    public class InvoiceItem : IInvoiceItem
    {
        public string NameItem { get; set; } = "";
        public string UnitOfMeasurement { get; set; } = "";
        public double Count { get; set; } = 1;
        public double SumWithoutNDS { get; set; }
        public double NDS { get; set; }
    }
}