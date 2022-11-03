using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreSample.Model.Entities
{
    public enum State
    {
        None,
        Open,
        InProgress,
        OpenInvoices,
        Completed,
        Cancelled
    }
}
