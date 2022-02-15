enum Color
{
    Red,
    Green,
    Blue
}

class ColorBoard
{
    static void WriteColor(Color color)
    {
        switch (color)
        {
            case Color.Red:
                Console.WriteLine("Red");
                break;
            case Color.Green:
                Console.WriteLine("Green");
                break;
            case Color.Blue:
                Console.WriteLine("Blue");
                break;
        }
    }
}

enum Align : sbyte
{
    Left = -1,
    Center = 0,
    Right = 1
}