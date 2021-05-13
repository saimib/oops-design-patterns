using System.Collections.Generic;

namespace design_patterns.Memento
{
  abstract class AbstractCommand {
    protected Application _application;
    protected IMemento _backup;
    public AbstractCommand(Application application)
    {
        _application = application;
    }
    public void SaveBackup() {
      _backup = _application.makeSnapshot();
    }
    public void Undo() {
      _application.Restore(_backup);
    }
    public abstract void execute();
  }
}