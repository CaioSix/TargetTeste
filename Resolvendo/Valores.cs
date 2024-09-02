using System;

class Valores
{
    static void Main()
    {
        Console.Write("Informe uma string para verificar a existência da letra 'a': ");
        string input = Console.ReadLine();

        int ocorrencias = ContarOcorrenciasDeA(input);

        if (ocorrencias > 0)
        {
            Console.WriteLine($"A letra 'a' (maiúscula ou minúscula) ocorre {ocorrencias} vezes na string.");
        }
        else
        {
            Console.WriteLine("A letra 'a' (maiúscula ou minúscula) não ocorre na string.");
        }
    }

    static int ContarOcorrenciasDeA(string texto)
    {
        int contador = 0;

        foreach (char c in texto)
        {
            if (c == 'a' || c == 'A')
            {
                contador++;
            }
        }

        return contador;
    }
}
