using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TheBank
{
    public class Transfer
    {
        public int id { get; set; }
        public int from { get; set; }
        public int to { get; set; }
        public double balance { get; set; }
    }
}
