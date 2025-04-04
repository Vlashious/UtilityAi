namespace UtilityAi
{
    public sealed class OneMinusCurve : IUtilityCurve
    {
        public float GetValue(float value)
        {
            return 1 - value;
        }
    }
}