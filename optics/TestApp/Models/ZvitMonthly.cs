using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Models
{
    class ZvitMonthly
    {
        public string Startmonth { get; set; }
        public string Endmonth { get; set; }
        public List<Monthlydata> items { get; set; }
    }
}
