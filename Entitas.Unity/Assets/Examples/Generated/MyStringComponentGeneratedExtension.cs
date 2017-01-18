//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {

    public sealed partial class VisualDebuggingEntity : Entity {

        public MyStringComponent myString { get { return (MyStringComponent)GetComponent(VisualDebuggingComponentIds.MyString); } }
        public bool hasMyString { get { return HasComponent(VisualDebuggingComponentIds.MyString); } }

        public void AddMyString(string newMyString) {
            var component = CreateComponent<MyStringComponent>(VisualDebuggingComponentIds.MyString);
            component.myString = newMyString;
            AddComponent(VisualDebuggingComponentIds.MyString, component);
        }

        public void ReplaceMyString(string newMyString) {
            var component = CreateComponent<MyStringComponent>(VisualDebuggingComponentIds.MyString);
            component.myString = newMyString;
            ReplaceComponent(VisualDebuggingComponentIds.MyString, component);
        }

        public void RemoveMyString() {
            RemoveComponent(VisualDebuggingComponentIds.MyString);
        }
    }
}

    public partial class VisualDebuggingMatcher {

        static IMatcher<VisualDebuggingEntity> _matcherMyString;

        public static IMatcher<VisualDebuggingEntity> MyString {
            get {
                if(_matcherMyString == null) {
                    var matcher = (Matcher<VisualDebuggingEntity>)Matcher<VisualDebuggingEntity>.AllOf(VisualDebuggingComponentIds.MyString);
                    matcher.componentNames = VisualDebuggingComponentIds.componentNames;
                    _matcherMyString = matcher;
                }

                return _matcherMyString;
            }
        }
    }
