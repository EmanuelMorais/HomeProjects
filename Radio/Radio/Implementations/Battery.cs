using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    public class Battery:IBattery
    {
        public bool SelfCheck()
        {
            return true;
        }

        public int ChargeRemaining()
        {
            return 70;
        }

        public string Manufacter()
        {
            return "EGM Enterprize";
        }

        public string SerialNumeber()
        {
            return "BSNEGM-"+Guid.NewGuid()+"-"+DateTime.Now.Day;
        }
    }
}
