using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    public class Dial
    {
        public string TypeOfDial { get; set; }

        public Dial(string typeOfDial)
        {
            TypeOfDial = typeOfDial;
        }

        public string DialType()
        {
            return TypeOfDial;
        }
    }
}
