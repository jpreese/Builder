using System;

namespace BuilderPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var autoMaker = new AutoMaker(new CarBuilder());
            var auto = autoMaker.BuildAuto();

            Console.WriteLine(auto.Brand);
            Console.WriteLine(auto.Color);
            Console.WriteLine(auto.Wheels);
            Console.WriteLine(auto.Mpg);
        }
    }
}
