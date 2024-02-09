using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractions
{
    
    public abstract class chair
    {
        public abstract void haslegs();
        public abstract void siton();
    }
    public abstract class sofa
    {
        public abstract void haslegs();
        public abstract void siton();

    }
    public abstract class coffeeTable
    {
        public abstract void haslegs();
        public abstract void siton();
    }

    public abstract class  furnitureFactory
    {
        public abstract chair createChair();
        public abstract sofa createSofa();
        public abstract coffeeTable createCoffeeTable();

    }


        
}
