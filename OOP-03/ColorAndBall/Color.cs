namespace OOP_03.ColorAndBall;

public class Color
{
    private int _red;
    private int _green;
    private int _blue;
    private int _alpha;

    public Color(int red, int green, int blue, int alpha)
    {
        SetRed(red);
        SetGreen(green);
        SetBlue(blue);
        SetAlpha(alpha);
    }

    public Color(int red, int green, int blue) : this(red, green, blue, 255)
    {
    }

    public int GetRed() => _red;
    public void SetRed(int value) => _red = ClampColorValue(value);

    public int GetGreen() => _green;
    public void SetGreen(int value) => _green = ClampColorValue(value);

    public int GetBlue() => _blue;
    public void SetBlue(int value) => _blue = ClampColorValue(value);

    public int GetAlpha() => _alpha;
    public void SetAlpha(int value) => _alpha = ClampColorValue(value);

    public int GetGrayscaleValue() => (_red + _green + _blue) / 3;

    private int ClampColorValue(int value)
    {
        return Math.Clamp(value, 0, 255);
    }
}