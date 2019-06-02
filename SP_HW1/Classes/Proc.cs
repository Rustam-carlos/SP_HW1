using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_HW1.Classes
{
    public class Proc
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string UserName { get; set; }
        public string CPU { get; set; }
        public long Memory { get; set; }
        public string Virtualization { get; set; }
    }
}
