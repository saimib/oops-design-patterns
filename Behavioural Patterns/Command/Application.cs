using System;
using System.Collections.Generic;

namespace design_patterns.Command
{
  class Application {
    public List<string> Cart = new List<string>();
    public string ItemSelected = "";
    private CommandHistory _history = new CommandHistory();
    public void SelectItem(string item) {
      ItemSelected = item;
    }
    public void ShowCart() {
      foreach (var item in Cart)
      {
          Console.WriteLine(item);
      }
    }
    public void executeCommand(AbstractCommand command) {
      _history.push(command);
      command.execute();
    }
    public void Undo() {
      _history.Pop()?.Undo();
    }
  }
}