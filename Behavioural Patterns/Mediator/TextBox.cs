namespace design_patterns.Mediator
{
    class TextBox : Component{
      public TextBox(IMediator mediator): base(mediator)
      {
          
      }

      public void Click(){
        Notify(this, "Text box clicked");
      }
    }
}