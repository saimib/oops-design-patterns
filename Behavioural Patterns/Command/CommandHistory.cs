using System.Collections.Generic;

namespace design_patterns.Command
{
  class CommandHistory {
    private Stack<AbstractCommand> _history = new Stack<AbstractCommand>();
    public void push(AbstractCommand command){
      _history.Push(command);
    }

    public AbstractCommand Pop(){
      return _history.Pop();
    }
  }
}