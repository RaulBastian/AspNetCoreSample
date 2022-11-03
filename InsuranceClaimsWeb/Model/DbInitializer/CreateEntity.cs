using AspNetCoreSample.Model.Entities;
using System;

namespace AspNetCoreSample.Model.DbInitializer
{
    public class CreateEntity
    {
        public static Expense Expense(int index)
        {
            return new Expense()
            {
                Price = index * 10,
                Description = $"This is the description for the workitem {index}"
            };
        }

        public static Appointment Appointment(Claim claim, List<Repairer> repairers)
        {
            var index = DbRandom.GetNumber(repairers.Count() - 1);

            return new Appointment()
            {
                Title = $"Appointment for claim {claim.Description}",
                Repairer = repairers[index],
                DateAndTime = DateTime.Now.AddDays(index * -1),
                IsStarted = DbRandom.GetNumber(1) == 0 ? true : false,
                IsFinished = false,
                Claim = claim
            };
        }

        public static PolicyHolder PolicyHolder(int i)
        {
            return new PolicyHolder
            {
                Name = $"Name{i}",
                Surname = $"Surname{i}",
                Description = $"Description {i}",
                Address = $"N{i}, Street {i}",
                PolicyNumber = i.ToString().PadLeft(8, '0')
            };
        }

        public static Repairer GetRepairerByName(string name, AspNetSampleDbContext context)
        {
            return context.Repairers.Where(r => r.Name == name).First();
        }

    }
}
