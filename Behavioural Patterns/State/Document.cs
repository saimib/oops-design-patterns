using System;

namespace design_patterns.State
{
    class Document {
    private IState _state;

    public Document()
    {
        _state = new Draft();
    }
    public void Render()
    {
      _state.Render();
    }
    public void Publish()
    {
      _state.Publish();
    }
    public void ChangeState(IState state) {
      _state = state;
    }
  }
}