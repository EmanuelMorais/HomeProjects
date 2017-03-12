using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerMax300Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Name = "Fish menu";

            MenuItem salmon = new MenuItem();
            MenuItem shark = new MenuItem();

            salmon.Title = "Fish";
            salmon.Description = "fresh salmon with potatos";
            salmon.Price = 23.30m;
            shark.Title = "Shark";
            shark.Price = 24.20m;
            shark.Description = "fresh shark with rice";

            menu.Items.Add(salmon);
            menu.Items.Add(shark);


            menu.PrintProperties();

        }



    }
}
