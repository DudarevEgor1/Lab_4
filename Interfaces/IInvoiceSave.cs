using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IInvoiceSave
    {
        void Save(IInvoice invoice);
        List<IInvoice> GetAll();
        void Update(IInvoice invoice);
    }
}
