using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    public interface ITunner
    {
        string Manufacter();
        int Frequency();
        bool SelfCheck();
        string SerialNumber();
    }
}
