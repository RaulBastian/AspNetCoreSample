using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreSample.Model.Entities
{
    public class PolicyHolder
    {
        public int Id { get; set; } 
        public string? PolicyNumber { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
    }
}
