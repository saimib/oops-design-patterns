using System;

namespace design_patterns.Chain_of_responsibility
{
  class RequestValidationHandler: BaseHandler {
    public override void handle(string request)
    {
      if(request != "Invalid Request")
        Console.WriteLine("Request Validated");
        base.handle(request);
    } 
  }
}