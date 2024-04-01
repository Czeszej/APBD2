using APBD2;

public class ConsoleApp1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello world");

        Container container1 = new Container(1000, 200, 1500, 50, APBD2.Type.G, 500, 1);

        Console.WriteLine(container1.ToString);
    }