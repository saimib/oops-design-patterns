namespace design_patterns.Memento
{
  class DeleteItemCommand: AbstractCommand {
    public DeleteItemCommand(Application application): base(application)
    {
    }
    public override void execute()
    {
      SaveBackup();
      _application.Remove(_application.GetSelectedItem());
    }
  }
}