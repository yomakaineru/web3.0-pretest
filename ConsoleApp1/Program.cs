// See https://aka.ms/new-console-template for more information
public class Hello
{
    public static void Main()
    {
        for (int i = 1; i <= 12; i++)
        {
            for (int t = 1; t <= 12; t++)
            {
                System.Console.Write($"{i * t,4:d} ");
            }
            System.Console.Write("\r\n");
        }
    }
}
