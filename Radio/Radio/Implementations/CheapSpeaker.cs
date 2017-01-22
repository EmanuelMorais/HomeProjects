using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Radio.Interfaces;

namespace Radio.Implementations
{
    public class CheapSpeaker : ISpeaker
    {
        public void Start()
        {
            Console.WriteLine("Cheap Speaker Playing");
            
        }
    }
}
