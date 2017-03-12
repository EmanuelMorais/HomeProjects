using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerMax300Console
{
    public class MenuItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                    _price = value;
                else
                    throw new ApplicationException("Price can't be 0 or negative");
            }
        }
    }
}
