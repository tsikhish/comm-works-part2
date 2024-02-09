using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractions
{
    public class victorianChair : chair
    {
        public override void haslegs()
        {
            Console.WriteLine("victorian legs");
        }
        public override void siton()
        {
            Console.WriteLine("sit on victorian chair");
        }
    }
    public class victorianSofa : sofa
    {
        public override void haslegs()
        {
            Console.WriteLine("victorian legs");
        }
        public override void siton()
        {
            Console.WriteLine("sit on victorian sofa");
        }
    }
    public class victorianCoffeetable : coffeeTable
    {
        public override void haslegs()
        {
            Console.WriteLine("victorian legs");
        }
        public override void siton()
        {
            Console.WriteLine("this is victorian coffee table");
        }
    }
    public class victorianFurniture : furnitureFactory
    {
        public override chair createChair() => new victorianChair();
        public override sofa createSofa() => new victorianSofa();
        public override coffeeTable createCoffeeTable() => new victorianCoffeetable();

    }
}
