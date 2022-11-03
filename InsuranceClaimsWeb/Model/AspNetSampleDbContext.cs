using AspNetCoreSample.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace AspNetCoreSample.Model
{
    public class AspNetSampleDbContext:DbContext
    {
        public AspNetSampleDbContext(DbContextOptions<AspNetSampleDbContext> options) :base(options)
        {
            
        }

        public DbSet<Claim> Claims { get; set; } = default(DbSet<Claim>)!;
        public DbSet<Appointment> Appointments { get; set; } = default(DbSet<Appointment>)!;
        public DbSet<Expense> Expenses { get; set; } = default(DbSet<Expense>)!;
        public DbSet<Invoice> Invoices { get; set; } = default(DbSet<Invoice>)!;
        public DbSet<PolicyHolder> PolicyHolders { get; set; } = default(DbSet<PolicyHolder>)!;
        public DbSet<Repairer> Repairers { get; set; } = default(DbSet<Repairer>)!;
    }
}
