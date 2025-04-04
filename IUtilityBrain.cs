namespace UtilityAi
{
    public interface IUtilityBrain
    {
        void AddAction(IUtilityAction action);
        void RemoveAction(IUtilityAction action);
        IUtilityAction? Decide();
    }
}