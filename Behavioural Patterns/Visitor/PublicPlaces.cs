namespace design_patterns.Visitor
{
    class PublicPlaces: INode{
    public void accept(IVisitor visitor)
    {
      visitor.VisitPublicPlaces(this);
    }
  }
}