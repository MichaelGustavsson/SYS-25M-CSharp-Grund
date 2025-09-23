namespace MakingDecisions;

class Program
{
    static void Main(string[] args)
    {
        /*
            DEL 1:
            Ofta när vi skriver kod behöver vi ibland fatta beslut baserat på information
            som vi får via applikationen eller via användaren av applikationen.
            I programmeringstermer kallas detta för villkorshantering.

            Det sätt som vi avgör vad som ska ske är med hjälp av if-satser.
            en if-sats kontrollerar ett villkor som vi ger den och om if-satsen
            avgör att villkoret är sant så kommer kod som finns direkt i if-satsens
            kodblock att köras.

            if-satser är väldigt vanliga i applikationsutveckling och därför är det viktigt
            att vi förstår hur dessa fungerar.

            Ett annat uttryck som oftast används för if-satser är "fatta beslut om vilken väg
            exekveringen i koden ska ta".

            Syntax: if(villkor)
            {
                kodblock som körs/exekveras om villkoret är sant
            }

            Vi kan även tala om för koden vad den ska göra om villkoret inte är sant.
            Vi gör det genom att lägga till en else-sats efter if-satsens kodblock.

            Syntax: if(villkor)
            {
                Om villkoret är sant så görs det som står här...
            }else
            {
                Annars så görs det som står här i else-satsens kodblock
            }

            - Villkor:
                Villkoret/villkoren som vi använder i en if-sats måste returnera sant eller falskt.
        */

        // Exempel 1:
        // Vi deklarerar en variabel av typen int...
        int age = 5;
        if (age > 5)
        {
            Console.WriteLine($"{age} är större än 5");
        }
        else
        {
            Console.WriteLine($"{age} är inte större än 5");
        }

        /*
            Detta kommer att ge oss utskriften "10 är större än 5"
        
            Om vi ändrar värdet på age till 3 så kommer vi få utskriften
            "3 är inte större än 5"
        */

        /*
            DEL 2:
            Ibland behöver vi kunna hantera flera fall för att veta vad som ska ske i koden.
            Vi kanske behöver kontrollera om age är lika med 5 förutom om age är större eller mindre
            Vad vi då kan göra är att addera en eller flera else if som betyder "annars om...".
        */

        // Exempel 2:
        // Vi använder samma variabel "age" som är deklarerad ovan...
        if (age > 5)
        {
            Console.WriteLine($"{age} är större än 5");
        }
        else if (age == 5)
        {
            // Om age är lika med 5 så hamnar vi här...
            Console.WriteLine($"{age} är lika med 5");
        }
        else
        {
            Console.WriteLine($"{age} är inte större än 5");
        }

        /* 
            Om vi nu ändrar variabelns värde till 5
            så får nu utskriften "5 är lika med 5"
        */

        /*
            DEL 3:
            Vi kan även använda fler villkor i en if-sats och separera villkoren med
            antingen två && tecken eller två || tecken
            && betyder och.
            || betydler eller.

            Om && används mellan två villkor så betyder det att båda villkoren måste
            vara sanna för att kodblocket efter if-satsen ska anropas.

            Om || används mellan två villkor så betyder det att det räcker med att ett
            av villkoren är sant.
        */

        // Exempel 3. &&(OCH) villkor...
        // Vi deklarerar två nya variabler...
        string firstName = "Eva";
        string lastName = "Eriksson";

        if (firstName == "Evald" && lastName == "Eriksson")
        {
            Console.WriteLine("Förnamn är Evald och Efternamn är Eriksson");
        }
        else
        {
            Console.WriteLine("Förnamn och Efternamn är inte Evald Eriksson");
        }

        /*
            Om vi nu kör applikationen så kommer utskriften att vara
            "Förnamn är Evald och Efternamn är Eriksson"

            Om vi nu ändrar till exempel förnamn till Eva får vi följande utskrift
            "Förnamn och Efternamn är inte Evald Eriksson"
        */

        // Exempel 4.
        /*
            Om vi nu istället ändrar && tecknet till ||
            Så får vi nu ett helt annat beteende på utfallet...
        */
        if (firstName == "Evald" || lastName == "Eriksson")
        {
            Console.WriteLine("Förnamn är Evald och Efternamn är Eriksson");
        }
        else
        {
            Console.WriteLine("Förnamn och Efternamn är inte Evald Eriksson");
        }

        /*
            Det som händer här är att nu räcker det med att ett av villkoren är sant
            för att vi ska få utskriften i if-satsens kodblock...
        */
    }
}
