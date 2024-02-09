using System;
using System.Reflection.PortableExecutable;

namespace facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.operationHTML();
            facade.operationPDF();
        }
    }
    class Facade
    {
        header header = new header();
        body body = new body();
        footer footer = new footer();
        public void operationHTML()
        {
            header.headerHTML();
            body.bodyHTML();
            footer.footerHTML();
        }
        public void operationPDF()
        {
            header.headerPDF();
            body.bodyPDF();
            footer.footerPDF();
        }
    }
    class header
    {
        public void headerHTML()
        {
            Console.WriteLine("<header> My Header </header> ");
        }   
        public void headerPDF()
        {
            Console.WriteLine("My Header");
        }
    }
    class body
    {
        public void bodyHTML()
        {
            Console.WriteLine("<body>Video provides a powerful way to help you prove your point. When you click Online Video, you can paste in the embed code for the video you want to add.</body> ");
        }
        public void bodyPDF()
        {
            Console.WriteLine("Video provides a powerful way to help you prove your point. When you click Online Video, you can paste in the embed code for the video you want to add.");
        }
    }
    class footer
    {
        public void footerHTML()
        {
            Console.WriteLine(" <footer>page 1 </footer> ");
        }
        public void footerPDF()
        {
            Console.WriteLine("page 1");
        }
    }
    
}
