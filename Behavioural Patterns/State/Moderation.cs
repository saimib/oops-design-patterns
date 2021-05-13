using System;

namespace design_patterns.State
{
    class Moderation: IState {

    private Document _document;
    public void Render()
    {
      Console.WriteLine("The Document is in Review");
    }
    public void Publish()
    {
      _document.ChangeState(new Published());
    }
  }
}