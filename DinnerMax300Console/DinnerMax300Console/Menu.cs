using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerMax300Console
{
    public class Menu
    {
        public string Name { get; set; }
        public List<MenuItem> Items { get; set; }

        public Menu()
        {
            Items = new List<MenuItem>();
        }

        public void PrintProperties()
        {
            Console.WriteLine("\t|__"+this.Name+"__|\n");
            this.Items.ForEach(m => Console.WriteLine("\tTitle: "+m.Title + "\n" +"\t Description: "+ m.Description + "\n" +"\t     Price: "+ m.Price + "\n"));
        }

    }
}
