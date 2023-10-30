using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public District District { get; set; }
    }
}
