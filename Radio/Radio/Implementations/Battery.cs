using System;
using Radio.Interfaces;

namespace Radio.Implementations
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
