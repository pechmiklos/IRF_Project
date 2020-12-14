using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magicsq
{
    public class Result
    {
        public  Guid Id  { get; set; }
        public string Gametype { get; set; }
        public int GameNumber { get; set; }
        public int Time { get; set; }

    }
}
