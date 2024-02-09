using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractions
{
    public class artdecoChair : chair
    {
        public override void haslegs()
        {
            Console.WriteLine("artdeco chair's legs");
        }
        public override void siton()
        {
            Console.WriteLine("sit on artdeco chair");
        }
    }
    public class artdecoSofa : sofa
    {
        public override void haslegs()
        {
            Console.WriteLine("artdeco sofa's legs");
        }
        public override void siton()
        {
            Console.WriteLine("sit on artdeco sofa");
        }
    }
    public class artdecoCoffeeTable : coffeeTable
    {
        public override void haslegs()
        {
            Console.WriteLine("artdeco coffee table's legs");
        }
        public override void siton()
        {
            Console.WriteLine("this is artdeco coffee table");
        }
    }
    public class artdecoFurniture : furnitureFactory
    {
        public override chair createChair() => new artdecoChair();
        public override sofa createSofa() => new artdecoSofa();
        public override coffeeTable createCoffeeTable() => new artdecoCoffeeTable();

    }
}
