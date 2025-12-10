using System;

class Program
{
    static void Main()

    {
        float a = 0;
        float b = 0;
        float c = 0;
        bool continuarLoop = true;

        while (continuarLoop == true)
        {
            b++;

            Console.WriteLine("insira um valor:");
            a += int.Parse(Console.ReadLine());

            Console.WriteLine(" digite a para continuar ou b para parar:");
            string opcaoEscolhida = Console.ReadLine();
            if (opcaoEscolhida == "b")
            {  continuarLoop=false; }
        }

        c = a / b;
        Console.WriteLine(c);
    }
}
