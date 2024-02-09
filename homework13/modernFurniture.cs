using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractions
{
    public class modernChair : chair
    {
        public override void haslegs()
        {
            Console.WriteLine("modern chair's legs");
        }
        public override void siton()
        {
            Console.WriteLine("sit on modern chair");
        }
    }
    public class modernSofa : sofa
    {
        public override void haslegs()
        {
            Console.WriteLine("modern sofa's legs");
        }
        public override void siton()
        {
            Console.WriteLine("sit on modern sofa");
        }
    }
    public class modernCoffeeTable : coffeeTable
    {
        public override void haslegs()
        {
            Console.WriteLine("modern coffee table's legs");
        }
        public override void siton()
        {
            Console.WriteLine("this is very modern coffee table");
        }
    }
    public class modernFurniture : furnitureFactory
    {
        public override chair createChair()=>new modernChair();
        public override sofa createSofa()=>new modernSofa();
        public override coffeeTable createCoffeeTable()=> new modernCoffeeTable();

    }


}
