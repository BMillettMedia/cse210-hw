using System;

public class Fraction
{
    private int top;
    private int bottom;

    public Fraction()
    {
        top=1;
        bottom=1;
    }

    public Fraction(int wholeNumber)
    {
        top = wholeNumber;
        bottom= 1;
    }

    public Fraction(int top, int bottom)
    {
        top=top;
        bottom=bottom;
    }

    public string GetFractionString()
    {
        string text = $"{top}/{bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)top/(double)bottom;
    }

}