using AspNetCoreSample.Model.Entities;
using System;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace AspNetCoreSample.Model.DbInitializer
{
    public static class CreateList
    {
        private const string Bob = "Bob";
        private const string Fred = "Fred";
        private const string Peter = "Peter";
        private const string John = "John";
        private const string Manuel = "Manuel";

        public static List<Appointment> Appointments(Claim claim, List<Repairer> repairers)
        {
            var appointments = new List<Appointment>();
            var index = DbRandom.GetNumber(5);

            for (var i = 0; i < index; i++)
            {
                appointments.Add(CreateEntity.Appointment(claim, repairers));
            }

            return appointments;
        }

        public static List<Expense> Expenses()
        {
            var expenses = new List<Expense>();
            var index = DbRandom.GetNumber(10);

            for (var i = 0; i < index; i++)
            {
                expenses.Add(CreateEntity.Expense(i));
            }

            return expenses;
        }

        public static List<Repairer> Repairers()
        {
            return new List<Repairer>()
            {
                new Repairer{ Name=Bob, Trade=Trade.Painter},
                new Repairer{ Name=Fred, Trade=Trade.Builder},
                new Repairer{ Name=Peter, Trade=Trade.Painter},
                new Repairer{ Name=John, Trade=Trade.Plumber},
                new Repairer{ Name=Manuel, Trade=Trade.Builder}
            };
        }

        public static List<Invoice> Invoices(IEnumerable<Expense> expenses, AspNetSampleDbContext context)
        {
            var invoices = new List<Invoice>();
            var index = DbRandom.GetNumber(expenses.Count());

            foreach (var chunk in expenses.Chunk(index == 0? 1: index).ToList())
            {
                var invoice = new Invoice();
                invoice.IsPaid = DbRandom.GetNumber(1) == 0 ? false : true;
                invoice.Expenses = context.Set<Expense>();
                invoice.Expenses.AddRange(chunk);
                invoices.Add(invoice);
            }

            return invoices;
        }
    }
}
