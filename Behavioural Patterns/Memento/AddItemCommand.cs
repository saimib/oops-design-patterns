namespace design_patterns.Memento
{
  class AddItemCommand: AbstractCommand {
    public AddItemCommand(Application application): base(application)
    {
    }
    public override void execute()
    {
      SaveBackup();
      _application.AddItem(_application.GetSelectedItem());
    }
  }
}