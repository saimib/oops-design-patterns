using System;

namespace design_patterns.Chain_of_responsibility
{
  class RequestHandler: BaseHandler {
    public override void handle(string request)
    {
      Console.WriteLine($"Request Handled Successfully - {request}");
    } 
  }
}