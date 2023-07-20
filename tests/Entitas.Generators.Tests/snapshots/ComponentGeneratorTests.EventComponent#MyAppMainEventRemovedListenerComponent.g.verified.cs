﻿//HintName: MyAppMainEventRemovedListenerComponent.g.cs
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by
//     Entitas.Generators.ComponentGenerator.Events
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public interface IMyAppMainEventRemovedListener
{
    void OnEventRemoved(global::MyApp.Main.Entity entity);
}

public sealed class MyAppMainEventRemovedListenerComponent : global::Entitas.IComponent
{
    public global::System.Collections.Generic.List<IMyAppMainEventRemovedListener> Value;
}

public static class MyAppMainEventRemovedListenerEventEntityExtension
{
    public static global::MyApp.Main.Entity AddEventRemovedListener(this global::MyApp.Main.Entity entity, IMyAppMainEventRemovedListener value)
    {
        var listeners = entity.HasEventRemovedListener()
            ? entity.GetEventRemovedListener().Value
            : new global::System.Collections.Generic.List<IMyAppMainEventRemovedListener>();
        listeners.Add(value);
        return entity.ReplaceEventRemovedListener(listeners);
    }

    public static void RemoveEventRemovedListener(this global::MyApp.Main.Entity entity, IMyAppMainEventRemovedListener value, bool removeListenerWhenEmpty = true)
    {
        var listeners = entity.GetEventRemovedListener().Value;
        listeners.Remove(value);
        if (removeListenerWhenEmpty && listeners.Count == 0)
        {
            entity.RemoveEventRemovedListener();
            if (entity.IsEmpty())
                entity.Destroy();
        }
        else
        {
            entity.ReplaceEventRemovedListener(listeners);
        }
    }
}

public sealed class MyAppMainEventRemovedEventSystem : global::Entitas.ReactiveSystem<global::MyApp.Main.Entity>
{
    readonly global::System.Collections.Generic.List<IMyAppMainEventRemovedListener> _listenerBuffer;

    public MyAppMainEventRemovedEventSystem(MyApp.MainContext context) : base(context)
    {
        _listenerBuffer = new global::System.Collections.Generic.List<IMyAppMainEventRemovedListener>();
    }

    protected override global::Entitas.ICollector<global::MyApp.Main.Entity> GetTrigger(global::Entitas.IContext<global::MyApp.Main.Entity> context)
    {
        return global::Entitas.CollectorContextExtension.CreateCollector(
            context, global::Entitas.TriggerOnEventMatcherExtension.Removed(MyAppMainEventMatcher.Event)
        );
    }

    protected override bool Filter(global::MyApp.Main.Entity entity)
    {
        return !entity.HasEvent() && entity.HasEventRemovedListener();
    }

    protected override void Execute(global::System.Collections.Generic.List<global::MyApp.Main.Entity> entities)
    {
        foreach (var entity in entities)
        {
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(entity.GetEventRemovedListener().Value);
            foreach (var listener in _listenerBuffer)
            {
                listener.OnEventRemoved(entity);
            }
        }
    }
}