using ClassesAndObjects;

class ExampleMain
{
    public static void Main()
    {
        Point[] points = new Point[100];
        for (int i = 0; i < 100; i++)
            points[i] = new Point(i, i);
    }
}