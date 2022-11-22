﻿using Invoice.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Infra.Data.Interfaces
{
    public interface IInvoiceInfoRepository : IGenericRepository<InvoiceInfo>
    {
        Task<List<InvoiceInfo>> GetInvoiceByCustomerID(int custId);
    }
}
