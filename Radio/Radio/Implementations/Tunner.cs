using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    public class Tunner : ITunner
    {
        public int Frequency()
        {
            return (int)101.1;
        }

        public string Manufacter()
        {
            return "EGM Enterprize";
            
        }

        public bool SelfCheck()
        {
            return true;
        }

        public string SerialNumber()
        {
            return "TSNEGM-" + Guid.NewGuid() + "-" + DateTime.Now.Day;
        }
    }
}
