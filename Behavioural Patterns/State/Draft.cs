using System;

namespace design_patterns.State
{
    class Draft: IState {

    private Document _document;
    public void Render()
    {
      Console.WriteLine("The Document is in Draft State");
    }
    public void Publish()
    {
      _document.ChangeState(new Moderation());
    }
  }
}