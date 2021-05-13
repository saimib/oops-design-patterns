using System;
using System.Collections.Generic;
using design_patterns.Abstract_Factory;
using design_patterns.Adapter;
using design_patterns.Bridge;
using design_patterns.Builder.Builders;
using design_patterns.Chain_of_responsibility;
using design_patterns.Command;
using design_patterns.Composite;
using design_patterns.Decorator;
using design_patterns.Facade;
using design_patterns.Factory;
using design_patterns.Flyweight;
using design_patterns.Iterator;
using design_patterns.Mediator;
using design_patterns.Memento;
using design_patterns.Observer;
using design_patterns.prototype;
using design_patterns.Proxy;
using design_patterns.Singleton;
using design_patterns.State;
using design_patterns.Strategy;
using design_patterns.Template;
using design_patterns.Visitor;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factory pattern
            var factory = new ClientUsingFactory();
            factory.doSomething();

            // Abstract Factory Pattern
            var abstractFactory = new ClientUsingAbstractFactories();
            abstractFactory.doSomething();

            // Builder Pattern
            var builderPattern = new ClientUsingBuilder();
            builderPattern.doSomething();

            // Prototype pattern
            var prototype = new ClientUsingPrototype();
            prototype.doSomething();

            // Singleton pattern
            var singleton = new ClientUsingSingleton();
            singleton.doSomething();

            // Adapter pattern
            var adapter = new ClientUsingAdapter();
            adapter.doSomething();

            // Bridge pattern
            var bridge = new ClientUsingBridge();
            bridge.doSomething();

            // Composite pattern
            var composite = new ClientUsingComposite();
            composite.doSomething();

            // Decorator pattern
            var decorator = new ClientUsingDecorator();
            decorator.doSomething();

            // Facade pattern
            var facade = new ClientUsingFacade();
            facade.doSomething();

            // Flyweight pattern
            var flyweight = new ClientUsingFlyweight();
            flyweight.doSomething();

            // Proxy pattern
            var proxy = new ClientUsingProxy();
            proxy.doSomething();

            // Proxy pattern
            var chainOfResponsibility = new ClientUsingChainOfResponsibility();
            chainOfResponsibility.doSomething();

            // Command pattern
            var command = new ClientUsingCommand();
            command.doSomething();

            // Iterator pattern
            var iterator = new ClientUsingIterator();
            iterator.doSomething();

            // Mediator pattern
            var mediator = new ClientUsingMediator();
            mediator.doSomething();

            // Memento pattern
            var memento = new ClientUsingMemento();
            memento.doSomething();

            // Observer pattern
            var observer = new ClientUsingObserver();
            observer.doSomething();

            // State pattern
            var state = new ClientUsingState();
            state.doSomething();

            // Strategy pattern
            var strategy = new ClientUsingStrategy();
            strategy.doSomething();

            // Template pattern
            var template = new ClientUsingTemplate();
            template.doSomething();

            // Visitor pattern
            var visitor = new ClientUsingVisitor();
            visitor.doSomething();
        }
    }
}
