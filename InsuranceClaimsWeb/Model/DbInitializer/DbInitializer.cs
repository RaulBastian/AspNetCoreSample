using AspNetCoreSample.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreSample.Model.DbInitializer
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            var context = applicationBuilder.ApplicationServices
                                            .CreateScope()
                                            .ServiceProvider
                                            .GetRequiredService<AspNetSampleDbContext>();

            if (context == null)
                throw new Exception("Context required");

            if (!context.Claims.Any())
            {
                var stateCount = Enum.GetNames<State>().Length;

                var repairers = CreateList.Repairers();
                context.Repairers.AddRange(repairers);

                for (int i = 0; i < 20; i++)
                {
                    var expenses = CreateList.Expenses();

                    var claim = new Claim
                    {
                        Description = $"Claim {i}",
                        PolicyHolder = CreateEntity.PolicyHolder(i),
                        Expenses = expenses,
                        State = Enum.GetValues<State>()[DbRandom.GetNumber(stateCount)]
                    };

                    claim.Appointments = CreateList.Appointments(claim, repairers);
                    claim.Invoices = CreateList.Invoices(expenses, context);

                    context.Claims.Add(claim);
                }

                context.SaveChanges();
            }
        }
    }

}
