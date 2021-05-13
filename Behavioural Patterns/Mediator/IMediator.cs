namespace design_patterns.Mediator
{
    interface IMediator {
      void Notify(Component component, string action);
    }
}