namespace EqualityCheck;

public static class EqualityChecker
{
    public static bool EqualsChecker(this object value, object comparasionValue)
    {
        return value.Equals(comparasionValue);
    }
}