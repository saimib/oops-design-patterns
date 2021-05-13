using System;

namespace design_patterns.Chain_of_responsibility
{
  class AuthorizationHandler: BaseHandler {
    public override void handle(string request)
    {
      if(request != "UnAuthorized Request")
        Console.WriteLine("Request Authorized");
        base.handle(request);
    } 
  }
}