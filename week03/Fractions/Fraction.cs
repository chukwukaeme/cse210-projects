public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
    _top = 1;
    _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public string GetFractionString()
    /*Notice that this is not store as a member variable
    It is just a temporary local variable that will be recomputed each time this is called. */
    {
        string text = $"{_top}/{_bottom}";
    return text;
    }
    public double GetDecimalValue()
    /*Notice that this is not stored as a member variable.
    It will be recomputed a=each time this is called. */
    {       
        return (double)_top / (double)_bottom;
    }
}