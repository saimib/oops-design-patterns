using System;

namespace design_patterns.Visitor
{
  class XMLExportVisitor : IVisitor{
    public void VisitHouse(House node)
    {
      Console.WriteLine("The visitor visits the house and exports the XML");
    }

    public void VisitPublicPlaces(PublicPlaces node)
    {
      Console.WriteLine("The visitor visits the Public Places and exports the XML");
    }

    public void VisitRoad(Road node)
    {
      Console.WriteLine("The visitor visits the Road and exports the XML");
    }
  }
}