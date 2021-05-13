namespace design_patterns.Command
{
  class AddItemCommand: AbstractCommand {
    public AddItemCommand(Application application): base(application)
    {
    }
    public override void execute()
    {
      SaveBackup();
      _application.Cart.Add(_application.ItemSelected);
    }
  }
}