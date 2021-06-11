using System;
using Kaffemaskinen.Interfaces;

//This class is the machine and contains everything all mashine needs to make a hot drink
namespace Kaffemaskinen
{
    public class Machine : IMakeHotDrink
    {
        public void PourWater()
        {
            Console.WriteLine("Pour Water");
        }

        public void Power()
        {
            Console.WriteLine("Turning Power on");
        }
    }
}