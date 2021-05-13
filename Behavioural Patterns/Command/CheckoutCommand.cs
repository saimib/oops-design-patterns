namespace design_patterns.Command
{
  class CheckoutCommand: AbstractCommand {
    public CheckoutCommand(Application application): base(application)
    {
    }
    public override void execute()
    {
      SaveBackup();
      _application.Cart.Clear();
    }
  }
}