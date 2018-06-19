namespace Visitor.Core
{
    public class Visitor : ICarVisitor, IEngineVisitor, ISeatVisitor
    {
        public string Mark { get; private set; }
        public string Name { get; private set; }
        public int Capacity { get; private set; }
        public string Model { get; private set; }
        public float Power { get; private set; }
        public float CylinderVolume { get; private set; }

        public void Visit(string mark, string model)
        {
            Mark = mark;
            Model = model;
        }

        public void Visit(float power, float cylinderVolume)
        {
            Power = power;
            CylinderVolume = cylinderVolume;
        }

        public void Visit(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }
    }
}