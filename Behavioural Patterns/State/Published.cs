using System;

namespace design_patterns.State
{
    class Published: IState {

    private Document _document;
    public void Render()
    {
      Console.WriteLine("The Document is Published");
    }
    public void Publish()
    {
      _document.ChangeState(new Draft());
    }
  }
}