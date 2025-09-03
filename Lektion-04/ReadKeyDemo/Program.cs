namespace ReadKeyDemo;

class Program
{
    static void Main()
    {
        ConsoleKeyInfo keyInfo;

        while (true)
        {
            keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            else if (char.IsNumber(keyInfo.KeyChar) || keyInfo.Key == ConsoleKey.Enter)
            {
                while (char.IsNumber(keyInfo.KeyChar))
                {
                    Console.WriteLine("Du gjorde följande inmatning: {0}", keyInfo.KeyChar);
                    keyInfo = Console.ReadKey(true);
                }
            }
            else
            {
                Console.WriteLine("Du måste ange ett numeriskt värde!");
            }
        }
    }
}
