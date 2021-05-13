namespace design_patterns.Adapter.Sql
{
  internal interface IDriver
  {
    public void CreateSQLCommand(string command);
    public void Execute();
  }
}