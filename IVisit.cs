namespace Visitor.Core
{
    public interface IVisit<in TVisitor> where TVisitor : IVisitor
    {
        void Visit(TVisitor visitor);
    }
}