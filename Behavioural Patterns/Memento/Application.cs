using System;
using System.Collections.Generic;

namespace design_patterns.Memento
{
  class Application {
    private List<string> _cart = new List<string>();
    private string ItemSelected = "";
    private CommandHistory _history = new CommandHistory();
    public void SelectItem(string item) {
      ItemSelected = item;
    }
    public string GetSelectedItem(){
      return ItemSelected;
    }

    public void AddItem(string item) {
      _cart.Add(item);
    }
    public void ShowCart() {
      foreach (var item in _cart)
      {
          Console.WriteLine(item);
      }
    }

    public IMemento makeSnapshot() {
      return new Backup(new List<string>(_cart));
    }

    public void Restore(IMemento snapshot) {
      var backup = (Backup)snapshot;
      _cart = backup.getState();
    }
    public void Clear(){
      _cart.Clear();
    }

    public void Remove(string item){
      _cart.Remove(item);
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