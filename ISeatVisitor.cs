namespace Visitor.Core
{
    public interface ISeatVisitor : IVisitor
    {
        void Visit(string name, int capacity);
    }
}