namespace design_patterns.Visitor
{
    interface INode{
      void accept(IVisitor visitor);
    }
}