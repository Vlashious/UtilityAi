using System.Collections.Generic;
using System.Linq;

namespace UtilityAi
{
    public sealed class UtilityBrain : IUtilityBrain
    {
        private readonly List<IUtilityAction> _actions = new List<IUtilityAction>();

        public void AddAction(IUtilityAction action)
        {
            _actions.Add(action);
        }

        public void RemoveAction(IUtilityAction action)
        {
            _actions.Remove(action);
        }

        public IUtilityAction? Decide()
        {
            IUtilityAction? action = _actions[0];
            var mostValuableAction = _actions.Aggregate(action, (x, y) =>
            {
                if (x?.CalculateUtility() < y?.CalculateUtility())
                {
                    action = y;
                    return action;
                }

                return action;
            });

            return mostValuableAction;
        }
    }
}