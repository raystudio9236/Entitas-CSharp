﻿//HintName: MyFeature.MultipleFieldsNamespacedComponent.MyApp.Main.Matcher.g.cs
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by
//     Entitas.Generators.ComponentGenerator.ComponentIndex
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using global::MyApp.Main;
using static global::MyFeature.MyAppMainMultipleFieldsNamespacedComponentIndex;

namespace MyFeature
{
public sealed class MyAppMainMultipleFieldsNamespacedMatcher
{
    static global::Entitas.IMatcher<Entity> _matcher;

    public static global::Entitas.IMatcher<Entity> MultipleFieldsNamespaced
    {
        get
        {
            if (_matcher == null)
            {
                var matcher = (global::Entitas.Matcher<Entity>)global::Entitas.Matcher<Entity>.AllOf(Index.Value);
                matcher.componentNames = MyApp.MainContext.ComponentNames;
                _matcher = matcher;
            }

            return _matcher;
        }
    }
}
}
