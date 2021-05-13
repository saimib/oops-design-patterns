namespace design_patterns.Chain_of_responsibility
{
    interface IHandler {
      void setNext(IHandler handler);
      void handle(string request);
    }
}