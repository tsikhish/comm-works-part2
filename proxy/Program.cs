using System;

namespace proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            acting acting = new actor();
            acting.act();
            cascador cascador = new cascador();
            cascador.act();
        }
    }
    abstract class acting
    {
        public abstract void act();
    }
    class actor : acting
    {
        public override void act()
        {
            Console.WriteLine("act in simple scenes");
        }
    }
    
    class cascador : acting
    {
        actor Icascador;
        public override void act()
        {
            if (Icascador == null)
            {
                Icascador = new actor();
            }
            Icascador.act();
            Console.WriteLine("and in hard scenes");
        }
    }
}
