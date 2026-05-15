using System;

namespace Inovoice
{
    public interface IInvoiceItem
    {
        string NameItem { get; set; }
        string UnitOfMeasurement { get; set; }
        double Count { get; set; }
        double SumWithoutNDS { get; set; }
        double NDS { get; set; }
    }
}