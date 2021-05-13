namespace design_patterns.Chain_of_responsibility
{
  class BaseHandler: IHandler {

    private IHandler _next;
    public void setNext(IHandler handler)
    {
      _next = handler;
    }

    public virtual void handle(string request)
    {
      if(_next != null)
        _next.handle(request);
    }
  }
}