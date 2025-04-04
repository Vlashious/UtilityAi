using System.Collections.Generic;

namespace UtilityAi
{
    public interface IUtilityAction
    {
        string Id { get; }
        IReadOnlyCollection<IUtilityConsideration> Considerations { get; }
        void Execute();
    }
}