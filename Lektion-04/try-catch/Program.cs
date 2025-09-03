namespace try_catch;

class Program
{
    static void Main()
    {
        // Design mönster som heter try catch finally...

        try // Försök att göra detta...
        {
            // Jag kastar ett eget undantag(fel);
            // throw new ArgumentException("Nu får du ge dig, du är helt bananas 😜");
            // throw new Exception("Nu får du ge dig, du är helt bananas 😜");

            int[] numbers = new int[5];

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;
            // numbers[5] = 6;

            foreach (var number in numbers)
            {
                Console.WriteLine("Här kommer ett nummer: {0}", number);
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("IndexOutOfRangeException | Det gick å H-E 🤪, {0} - {1} ", ex.Message, ex.StackTrace);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("ArgumentException | {0}", ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception | {0}", ex.Message);
        }
        finally
        {
            // Eventuellt kan städa upp det som gick bra eller även det som gick sämre
            Console.WriteLine("Jag är här oavsett vad som hände ovan, 🙏");
        }
    }
}
