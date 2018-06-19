namespace Visitor.Core
{
    public interface ICarVisitor : IVisitor
    {
        void Visit(string mark, string model);
    }
}