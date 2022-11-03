using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreSample.Model.Entities
{
    public class Claim
    {
        public int Id { get; set; }
        public PolicyHolder PolicyHolder { get; set; } = default(PolicyHolder)!;
        public List<Appointment> Appointments { get; set; } = default(List<Appointment>)!;
        public List<Invoice> Invoices { get; set; } = default(List<Invoice>)!;
        public List<Expense> Expenses { get; set; } = default(List<Expense>)!;
        public State State { get; set; } = default(State)!;
        public string Description { get; set; } = default(string)!;
    }
}
