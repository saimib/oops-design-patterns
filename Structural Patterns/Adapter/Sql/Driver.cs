using System;

namespace design_patterns.Adapter.Sql
{
  class Driver : IDriver
  {
    private string _command = "default command";
    public void CreateSQLCommand(string command)
    {
      this._command = command;
    }

    public void Execute()
    {
      Console.WriteLine(this._command);
    }
  }
}