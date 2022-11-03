using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreSample.Model.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public bool IsPaid { get; set; }
        public DbSet<Expense> Expenses { get; set; } = default(DbSet<Expense>)!;
    }
}
