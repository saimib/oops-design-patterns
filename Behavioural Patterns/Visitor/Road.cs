namespace design_patterns.Visitor
{
    class Road: INode{
    public void accept(IVisitor visitor)
    {
      visitor.VisitRoad(this);
    }
  }
}