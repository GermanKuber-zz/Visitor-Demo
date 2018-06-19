using System;
using System.Collections.Generic;

namespace Visitor.Core
{
    class Program
    {
        static void Main(string[] args)
        {

            var engine = new Engine(123, 123);
            var list = new List<Seat> { new Seat("Algo", 1), new Seat("Algo 2", 2) };
            var car = new Car("alguna", "Modelo", engine, list);

            var visitor = new Visitor();
            engine.Visit(visitor);
            list.ForEach(x=> x.Visit(visitor));
            car.Visit(visitor);  
            

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}