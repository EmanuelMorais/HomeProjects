using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Radio.Interfaces;

namespace Radio.Implementations
{
    public class Casing : ICasing
    {
        private readonly string typeOfMaterial;

        public Casing(string typeOfMaterial)
        {
            this.typeOfMaterial = typeOfMaterial;
        }


        public string TypeOfMaterial()
        {
            return ("Type of material: "+typeOfMaterial);
        }
    }
}
