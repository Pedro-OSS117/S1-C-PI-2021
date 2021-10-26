class MyMath
{
    public static float CalculeMoyenne(float total, int nombreElement)
    {
        return total / nombreElement;
    }

    public static float CalculeSurface(float largeur, float hauteur)
    {
        return largeur * hauteur;
    }

    public static float CalculatePercent(float value, float value100Percent)
    {
        return value * 100 / value100Percent;
    }
}