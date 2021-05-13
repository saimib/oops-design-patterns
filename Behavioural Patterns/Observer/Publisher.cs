using System;
using System.Collections.Generic;

namespace design_patterns.Observer {
  class Publisher {
    private List<ISubscriber> _subscribers = new List<ISubscriber>();
    private string _state;
    private void notifySubscribers() {
      foreach (var item in _subscribers)
      {
          item.update("State changed");
      }
    }
    public void Subscribe(ISubscriber subscriber) {
      _subscribers.Add(subscriber);
    }
    public void UnSubscribe(ISubscriber subscriber) {
      _subscribers.Remove(subscriber);
    }
    public void UpdateState(string newState) {
      _state = newState;
      notifySubscribers();
    }    
  }
}