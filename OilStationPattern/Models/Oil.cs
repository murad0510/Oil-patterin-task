using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilStationPattern.Models
{
    public class Oil
    {
        public int OilId { get; set; }
        public string OilName { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return $"{OilName} - {Price}";
        }
    }
}
