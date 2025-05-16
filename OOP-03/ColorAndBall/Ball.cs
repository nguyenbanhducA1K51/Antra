namespace OOP_03.ColorAndBall;

public class Ball
{
    private int _size;
    private Color _color;
    private int _throwCount;

    public Ball(int size, Color color)
    {
        _size = size;
        _color = color;
        _throwCount = 0;
    }

    public void Pop() => _size = 0;

    public void Throw()
    {
        if (_size > 0)
        {
            _throwCount++;
        }
    }

    public int GetThrowCount() => _throwCount;

    public int GetSize() => _size;

    public Color GetColor() => _color;
}