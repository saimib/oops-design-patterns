namespace design_patterns.Mediator
{
    class Button : Component{
      public Button(IMediator mediator): base(mediator)
      {
          
      }

      public void Click(){
        Notify(this, "Button Clicked");
      }
    }
}