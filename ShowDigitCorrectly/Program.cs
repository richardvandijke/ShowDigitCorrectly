using System;
using System.Globalization;

Console.WriteLine("Hello, Welcome");
Keuze();

static void Keuze()
{
    /* MAAK BOOLEAN VAN 13 LEDS
     * LED 8, 12, 13 WORDEN NIET AANGEPAST IN LOOPS
     */ 
    
    bool[] ledId = new bool[13];
    ledId[7] = true;
    ledId[12] = true;
    
    Console.WriteLine("\nPlease press a number key");
    Console.WriteLine("[0..9] or [Q]uit");

    string vraagInput = Console.ReadLine();
    Console.Clear();

    LedCheck(vraagInput, ledId);
}

// ZET DE LEDS AAN INDIEN NODIG (STANDAARD ZIJN ZE UIT)

static void LedCheck(string vraagInput,bool[] ledId)
{

    if (vraagInput == "0")
    {
        ledId[0] = true;
        ledId[1] = true;
        ledId[2] = true;
        ledId[3] = true;
        ledId[4] = true;
        ledId[5] = true;
        //ledId[6] = true;
        ledId[8] = true;
        ledId[9] = true;
        ledId[10] = true;       
    }
    else if (vraagInput == "1")
    {
        //ledId[0] = true;
        //ledId[1] = true;
        ledId[2] = true;
        //ledId[3] = true;
        ledId[4] = true;
        //ledId[5] = true;
        //ledId[6] = true;
        //ledId[8] = true;
        ledId[9] = true;
        //ledId[10] = true;
    }
    else if (vraagInput == "2")
    {
        ledId[0] = true;
        ledId[1] = true;
        ledId[2] = true;
        //ledId[3] = true;
        ledId[4] = true;
        ledId[5] = true;
        ledId[6] = true;
        ledId[8] = true;
        //ledId[9] = true;
        ledId[10] = true;
    }
    else if (vraagInput == "3")
    {
        ledId[0] = true;
        ledId[1] = true;
        ledId[2] = true;
        //ledId[3] = true;
        ledId[4] = true;
        ledId[5] = true;
        ledId[6] = true;
        //ledId[8] = true;
        ledId[9] = true;
        ledId[10] = true;
    }
    else if (vraagInput == "4")
    {
        ledId[0] = true;
        //ledId[1] = true;
        ledId[2] = true;
        ledId[3] = true;
        ledId[4] = true;
        ledId[5] = true;
        ledId[6] = true;
        //ledId[8] = true;
        ledId[9] = true;
        //ledId[10] = true;
    }
    else if (vraagInput == "5")
    {
        ledId[0] = true;
        ledId[1] = true;
        ledId[2] = true;
        ledId[3] = true;
        //ledId[4] = true;
        ledId[5] = true;
        ledId[6] = true;
        //ledId[8] = true;
        ledId[9] = true;
        ledId[10] = true;
    }
    else if (vraagInput == "6")
    {
        ledId[0] = true;
        //ledId[1] = true;
        //ledId[2] = true;
        ledId[3] = true;
        //ledId[4] = true;
        ledId[5] = true;
        ledId[6] = true;
        ledId[8] = true;
        ledId[9] = true;
        ledId[10] = true;
    }
    else if (vraagInput == "7")
    {
        ledId[0] = true;
        ledId[1] = true;
        ledId[2] = true;
        //ledId[3] = true;
        ledId[4] = true;
        //ledId[5] = true;
        //ledId[6] = true;
        //ledId[8] = true;
        ledId[9] = true;
        //ledId[10] = true;
    }
    else if (vraagInput == "8")
    {
        ledId[0] = true;
        ledId[1] = true;
        ledId[2] = true;
        ledId[3] = true;
        ledId[4] = true;
        ledId[5] = true;
        ledId[6] = true;
        ledId[8] = true;
        ledId[9] = true;
        ledId[10] = true;
    }
    else if (vraagInput == "9")
    {
        ledId[0] = true;
        ledId[1] = true;
        ledId[2] = true;
        ledId[3] = true;
        ledId[4] = true;
        ledId[5] = true;
        ledId[6] = true;
        //ledId[8] = true;
        ledId[9] = true;
        //ledId[10] = true;
    }
    else if ((vraagInput == "q") || (vraagInput == "Q"))
    {
        Environment.Exit(0);
    }
    else  // GEEFT E VAN ERROR = ANTI CRASH :) 
    {
        ledId[0] = true;
        ledId[1] = true;
        ledId[2] = true;
        ledId[3] = true;
        //ledId[4] = true;
        ledId[5] = true;
        ledId[6] = true;
        ledId[8] = true;
        //ledId[9] = true;
        ledId[10] = true;
    }
    
    ledId[11] = ledId[10];
    LedChange(ledId);

}

// TEKENEN VAN OUTPUT

static void LedChange(bool[] ledId)
{
    int j = 0;
    foreach (bool i in ledId)
    {
        if ((j == 4) || (j == 9)) Console.Write(" ");
        if ((j == 3) || (j == 5) || (j == 8) || (j == 10)) Console.Write("\n");
        
        if (ledId[j] == true)

            Console.Write("▓");
        else
            Console.Write("░");  

        j++;
    }

    Keuze();
}