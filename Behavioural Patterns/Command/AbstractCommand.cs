using System.Collections.Generic;

namespace design_patterns.Command
{
  abstract class AbstractCommand {
    protected Application _application;
    protected Backup _backup = new Backup();
    public AbstractCommand(Application application)
    {
        _application = application;
    }
    public void SaveBackup() {
      _backup.Cart = new List<string>(_application.Cart);
    }
    public void Undo() {
      _application.Cart = _backup.Cart;
    }
    public abstract void execute();
  }
}