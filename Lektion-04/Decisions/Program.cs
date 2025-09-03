namespace Decisions;

class Program
{
    static void Main()
    {
        // Beslutsfattande i kod exekvering...
        // Baserat på villkor avgöra vad koden ska göra härnäst.
        // if eller switch
        /*
            if bygger på om villkoret är sant så gör vi det som 
            kommer härnäst

            if(x == 10) <=

            else - if

            nästlade if satser => if i if i if
        */

        // =============================================================
        // if med jämförelse operatorn lika med (==)
        // =============================================================
        // int x = 3;
        // string name = "Michael";

        // if (x == 1)
        // {
        //     if (name == "Michael")
        //     {
        //         Console.WriteLine("X = {0} - name: {1}", x, name);
        //     }
        //     else
        //     {
        //         Console.WriteLine("X = {0}", x);
        //     }
        // }
        // else if (x == 2)
        // {
        //     Console.WriteLine("X = {0}", x);
        // }
        // else if (x == 3)
        // {
        //     Console.WriteLine("X = {0}", x);
        // }
        // else if (x == 4)
        // {
        //     Console.WriteLine("X = {0}", x);
        // }
        // else if (x == 5)
        // {
        //     Console.WriteLine("X = {0}", x);
        // }
        // else if (x == 6)
        // {
        //     Console.WriteLine("X = {0}", x);
        // }
        // else if (x == 7)
        // {
        //     Console.WriteLine("X = {0}", x);
        // }
        // else
        // {
        //     // Om inte x är lika med 7 så hamnar vi här...
        //     Console.WriteLine("Hoppsan jag hamnade här till slut...");
        // }

        // int x = 3;

        // if (x > 3)
        // {
        //     Console.WriteLine("X är större än 3");
        // }
        // else
        // {
        //     Console.WriteLine("X är inte större än 3");
        // }

        // if (x >= 3)
        // {
        //     Console.WriteLine("X är större än eller lika med 3");
        // }
        // else
        // {
        //     Console.WriteLine("X är inte större än 3");
        // }

        // if (x < 3)
        // {
        //     Console.WriteLine("X är mindre än 3");
        // }
        // else
        // {
        //     Console.WriteLine("X är inte mindre än 3");
        // }

        // if (x <= 3)
        // {
        //     Console.WriteLine("X är mindre än eller lika med 3");
        // }
        // else
        // {
        //     Console.WriteLine("X är inte mindre än 3");
        // }

        // // ! är inte operatorn, negerar uttrycket...
        // if (x != 3)
        // {
        //     // Gör något...
        // }

        // && = och, || = eller...
        // int y = 10;
        // string name = "Michael";

        // if (y == 20 && name == "Michael")
        // {
        //     Console.WriteLine("Det stämmer!!!");
        // }

        // if (y == 20 || name == "Kalle")
        // {
        //     Console.WriteLine("Det stämmer!!!");
        // }

        // =============================================================
        // switch statement kan komprimera en lång if och else if sats
        // =============================================================

        int x = 3;

        switch (x)
        {
            // if(x == 1)
            case 1:
            // else if(x == 2)
            case 2:
                Console.WriteLine("switch är nu x: {0}", x);
                break;
            // else if(x == 3)
            case 3:
                Console.WriteLine("switch är nu 3");
                break;
            case 4:
                Console.WriteLine("switch är nu 4");
                break;
            case 5:
                Console.WriteLine("switch är nu 5");
                break;
            case 6:
                Console.WriteLine("switch är nu 6");
                break;
            case 7:
                Console.WriteLine("switch är nu 7");
                break;
            // else
            default:
                Console.WriteLine("Nähä, då gör vi något annat");
                break;
        }
    }
}
