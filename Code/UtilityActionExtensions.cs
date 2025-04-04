namespace UtilityAi
{
    public static class UtilityActionExtensions
    {
        public static float CalculateUtility(this IUtilityAction action)
        {
            var utility = 1f;

            foreach (var consideration in action.Considerations)
            {
                utility *= consideration.Value;
            }

            return utility;
        }
    }
}