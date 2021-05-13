using System;

namespace design_patterns.Decorator
{
    class BaseDecorator : INotifier {

      private INotifier _notifier;

      public BaseDecorator(INotifier notifier)
      {
          _notifier = notifier;
      }
      public virtual void sendMessage(string data) {
        _notifier.sendMessage(data);
      }
    }
}