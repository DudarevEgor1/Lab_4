using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IInvoiceItem
    {
        public string NameItem { get; set; }
        string UnitOfMasurement { get; set; }
        double Count { get; set; }
        double SumWithoutNDS { get; set; }
        double NDS { get; set; }
        double PercentNDS { get; }
    }
}
