using System;

namespace UtilityAi
{
    public interface IUtilityActionSerializer<T>
    {
        void RegisterParserFor(IUtilityAction action, Func<T, IUtilityAction> parser);
        IUtilityAction ParseAction(T value);
    }
}