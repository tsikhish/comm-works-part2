using System;

namespace abstractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            furnitureFactory factory = new victorianFurniture();
            chair chair = factory.createChair();
            sofa sofa=factory.createSofa();
            coffeeTable coffeeTable = factory.createCoffeeTable();
            chair.haslegs();
        }
    }
}
