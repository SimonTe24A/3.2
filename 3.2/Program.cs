using System;

class Program
{
    static void Main()
    {
        Console.Write("Har du gått ut gymnasiet? Svara ja för ja eller nej: ");
        string svar = Console.ReadLine();

        Console.Write("Hur gammal är du? ");
        int alder = int.Parse(Console.ReadLine());

        if (svar == "ja" && alder < 22)
        {
            Console.WriteLine("Vi vill gärna anställa dig");
        }
        else
        {
            Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
            Console.WriteLine("Du är för gammal för oss tyvärr");
        }
    }
}
    