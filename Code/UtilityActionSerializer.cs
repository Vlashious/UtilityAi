using System;
using System.Collections.Generic;

namespace UtilityAi
{
    public sealed class UtilityActionSerializer : IUtilityActionSerializer<string>
    {
        private readonly Dictionary<Type, Func<string, IUtilityAction>> _factories =
            new Dictionary<Type, Func<string, IUtilityAction>>();

        public void RegisterParserFor(IUtilityAction action, Func<string, IUtilityAction> parser)
        {
            _factories[action.GetType()] = parser;
        }

        public IUtilityAction ParseAction(string json)
        {
            return _factories[json.GetType()](json);
        }
    }
}