namespace Cowboy.Game.Casting
{

    public class Color
{
    // The red, green, blue, and alpha (transparency) values for this color,
    // represented as integers in the range 0-255.
    private int _red;
    private int _green;
    private int _blue;
    private int _alpha;

    public Color(int red, int green, int blue, int alpha = 255)
    {
        // Assign the provided values to the instance variables.
        this._red = red;
        this._green = green;
        this._blue = blue;
        this._alpha = alpha;
    }

    // Returns the alpha value for this color.
    public int GetAlpha()
    {
        return _alpha;
    }

    // Returns the blue value for this color.
    public int GetBlue()
    {
        return _blue;
    }

    // Returns the green value for this color.
    public int GetGreen()
    {
        return _green;
    }

    // Returns the red value for this color.
    public int GetRed()
    {
        return _red;
    }
}

}