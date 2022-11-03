using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreSample.Model.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public Claim Claim { get; set; } = default(Claim)!;
        public DateTime DateAndTime { get; set; }
        public string? Title { get; set; }
        public Repairer Repairer { get; set; } = default(Repairer)!;
        public bool IsStarted { get; set; }
        public bool IsFinished { get; set; }
    }
}
