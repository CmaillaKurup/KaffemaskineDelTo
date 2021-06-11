using System;
using Kaffemaskinen.Interfaces;

//This class only make coffee
namespace Kaffemaskinen
{
    public class Coffee : Machine, IMakeCoffee
    {
        public void PourBeans()
        {
            Console.WriteLine("Puring Beans");
        }

        public void InsertFilter()
        {
            Console.WriteLine("inserting Filter");
        }
    }
}