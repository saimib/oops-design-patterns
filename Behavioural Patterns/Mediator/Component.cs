namespace design_patterns.Mediator
{
    abstract class Component {
      private IMediator _mediator;

      protected Component(IMediator mediator)
      {
          _mediator = mediator;
      }

      protected void Notify(Component component, string action) {
        _mediator.Notify(component, action);
      }
      
    }
}