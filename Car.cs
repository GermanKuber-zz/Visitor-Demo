using System.Collections.Generic;

namespace Visitor.Core
{
    class Car : IVisit<ICarVisitor>
    {

        private readonly string _make;
        private readonly string _model;
        private readonly Engine _engine;
        private readonly IEnumerable<Seat> _seats;

        public Car(string make, string model, Engine engine, IEnumerable<Seat> seats)
        {
            _make = make;
            _model = model;
            _engine = engine;
            _seats = new List<Seat>(seats);
        }

        public void Visit(ICarVisitor visitor)
        {
            visitor.Visit(_make, _model);
        }
    }
}