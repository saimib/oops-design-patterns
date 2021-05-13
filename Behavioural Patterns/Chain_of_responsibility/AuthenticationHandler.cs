using System;

namespace design_patterns.Chain_of_responsibility
{
  class AuthenticationHandler: BaseHandler {
    public override void handle(string request)
    {
      if(request != "UnAuthenticated Request")
        Console.WriteLine("Request Authenticated");
        base.handle(request);
    } 
  }
}