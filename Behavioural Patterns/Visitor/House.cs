namespace design_patterns.Visitor
{
    class House: INode{
    public void accept(IVisitor visitor)
    {
      visitor.VisitHouse(this);
    }
  }
}