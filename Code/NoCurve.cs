namespace UtilityAi
{
    public sealed class NoCurve : IUtilityCurve
    {
        public float GetValue(float value)
        {
            return value;
        }
    }
}