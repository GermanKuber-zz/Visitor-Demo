using System.Collections.Generic;

namespace Visitor.Core
{
    public class Seat : IVisit<ISeatVisitor>
    {

        private string _name;
        private int _capacity;

        public Seat(string name, int capacity)
        {
            this._name = name;
            this._capacity = capacity;
        }



        public static IEnumerable<Seat> FourSeatConfiguration
        {
            get
            {
                return new Seat[]
                {
                    new Seat("Driver", 1),
                    new Seat("Passenger", 1),
                    new Seat("Rear bench", 2)
                };
            }
        }

        public static IEnumerable<Seat> TwoSeatConfiguration
        {
            get
            {
                return new Seat[]
                {
                    new Seat("Driver", 1),
                    new Seat("Passenger", 1)
                };
            }
        }

        public void Visit(ISeatVisitor visitor)
        {
            visitor.Visit(_name, _capacity);
        }
    }
}
