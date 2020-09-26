public class DisplayTriangle
{

    public static void Main()
    {


        Console.Error.WriteLine("Type 'a' = lower left triangle; 'b' = upper left triangle; 'c' = upper right triangle; 'd' = lower right triangle.");
        char t = Convert.ToChar(Console.ReadLine());
        Console.Error.WriteLine("Enter the number of lines.");
        int n = Convert.ToInt32(Console.ReadLine());
    }

    const string STAR = "*";
    const string SPACE = " ";
    const int COUNTER = 10;

    static void Main(string[] args)
    {
        DisplayA();
        DisplayB();
        DisplayC();
        DisplayD();

        Console.ReadLine();
    }

    static public void DisplayA()
    {
        int index = 0;
        int c = 0;
        for (index = 0; index < COUNTER; index++)
        {
            for (c = 0; c <= index; c++)
                Console.Write(STAR);

            Console.WriteLine();    //new line after each row
        }
        Console.WriteLine();    //new line after pattern
    }

    static public void DisplayB()
    {
        int index = 0;
        int c = 0;

        for (index = 0; index < COUNTER; index++)
        {
            for (c = 0; c < index; c++)
                Console.Write(SPACE);

            for (c = 0; c < COUNTER - index; c++)
                Console.Write(STAR);

            Console.WriteLine();    //new line after each row
        }
        Console.WriteLine();    //new line after pattern

    }

    static public void DisplayC()
    {

        int index = 0;
        int c = 0;
        for (index = COUNTER; index > 0; index--)
        {
            for (c = 0; c < index; c++)
                Console.Write(STAR);

            Console.WriteLine();    //new line after each row
        }
        Console.WriteLine();    //new line after pattern
    }

    static public void DisplayD()
    {
        int index = 0;
        int c = 0;

        for (index = COUNTER; index >= 0; index--)
        {
            for (c = 0; c < index; c++)
                Console.Write(SPACE);

            for (c = 0; c < COUNTER - index; c++)
                Console.Write(STAR);

            Console.WriteLine();    //new line after each row
        }
        Console.WriteLine();    //new line after pattern
    }

}
    }