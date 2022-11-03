using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreSample.Model.Entities
{
    public class Repairer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Trade Trade { get; set; }
    }
}
