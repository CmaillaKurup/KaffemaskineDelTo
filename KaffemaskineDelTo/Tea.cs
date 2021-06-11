using System;
using Kaffemaskinen;
using Kaffemaskinen.Interfaces;

namespace KaffemaskineDelTo
{
    public class Tea : Machine, IMakeTea
    {
        public void InsertFilter()
        {
            Console.WriteLine("Inserting Filter");
        }

        public void AddTeaLeafs()
        {
            Console.WriteLine("Adding Tea Leafs");
        }
    }
}