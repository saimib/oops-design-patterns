namespace design_patterns.Command
{
  class DeleteItemCommand: AbstractCommand {
    public DeleteItemCommand(Application application): base(application)
    {
    }
    public override void execute()
    {
      SaveBackup();
      _application.Cart.Remove(_application.ItemSelected);
    }
  }
}