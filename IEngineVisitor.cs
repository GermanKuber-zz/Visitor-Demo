namespace Visitor.Core
{
    public interface IEngineVisitor : IVisitor
    {
        void Visit(float power, float cylinderVolume);
    }
}