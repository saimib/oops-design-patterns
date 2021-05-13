namespace design_patterns.Visitor
{
  interface IVisitor{
    void VisitHouse(House node);
    void VisitRoad(Road node);
    void VisitPublicPlaces(PublicPlaces node);
  }   
}