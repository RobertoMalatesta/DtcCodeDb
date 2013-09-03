using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Objects
{
    public class DtcCodeObject
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public string DTC { get; set; }
        public int Year { get; set; }
    }
}
