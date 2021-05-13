namespace design_patterns.Memento
{
  class CheckoutCommand: AbstractCommand {
    public CheckoutCommand(Application application): base(application)
    {
    }
    public override void execute()
    {
      SaveBackup();
      _application.Clear();
    }
  }
}