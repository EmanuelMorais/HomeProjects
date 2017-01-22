using System;
using Radio.Interfaces;

namespace Radio.Implementations
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
