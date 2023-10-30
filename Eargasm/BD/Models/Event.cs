using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        //public Images Image { get; set; }
        public Category Category { get; set; }
        public Company Company { get; set; }
        public City City { get; set; }
        //public District District { get; set; }
        //public Country Country { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public bool Restriction { get; set; }
        public Comments Comments { get; set; }
    }
}
