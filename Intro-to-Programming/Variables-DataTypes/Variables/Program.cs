namespace Variables;

class Program
{
    static void Main()
    {
        /*
            När vi bygger applikationer måste vi ofta hantera data
            eller information som vi behöver ha tillgång till i olika
            skeden av applikationens exekvering.

            För att hantera data skapar vi variabler,
            en variabel är endast ett namn som vi skapar sedan
            talar vi om vilken typ av information som variabeln ska kunna
            lagra och hantera genom att ge variabeln en datatyp.

            Om vi till exempel vill lagra ålder för en person i vår applikation
            så kan vi skriva följande:

            int age;

            int är datatypen och age är namnet vi vill använda detta skapar
            en variabel som heter age och lagra informationen som ett heltal.

            Ett annat uttryck som ofta används är att vi deklarerar en variabel
            och det är precis det som vi gjort här.

            Behöver lagra namnet på en person så kan vi "deklarera" en variabel
            på följande sätt:

            string name;

            Vad vi ytterligare kan göra när vi deklarerar våra variabler är att
            ge dem startvärden, kallas för att vi initierar våra variabler med 
            ett standardvärde.
            Så vi kan skriva om ovanstående variabler på följande sätt:

            int age = 30;
            string name = "Eva Olsson";

            Nedan följer ett exempel:
        */

        int age = 25;
        string name = "Eva Olsson";
        bool hasDriversLicens = true;
        decimal salary = 400000;

        Console.WriteLine($"{name} är {age} år och har körkort ({hasDriversLicens}) samt tjänar {salary} om året.");
    }
}
