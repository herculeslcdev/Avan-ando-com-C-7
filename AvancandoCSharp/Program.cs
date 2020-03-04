using System;
using static System.Console;
using System.Globalization;

namespace AvancandoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Hoje à noite, sem luz, decidi xeretar a quinta gaveta de vovô: achei lingüiça, pão e fubá";

            // realiza replace independente de CAPS LOCK
            string frase_trocada = frase.Replace("VOVô", "mamãe", true, CultureInfo.CurrentCulture);
            WriteLine(frase_trocada);

            /*
            WriteLine(frase.ToUpper());
            WriteLine(frase.ToLower());
            */

            /* pegar fatias da string
            string subFrase = "achei";
            var posInicial = frase.IndexOf(subFrase);
            var posFinal = 10;
            string sub = frase.Substring(posInicial);
            WriteLine(sub);
            */
            /*
            var pos = frase.IndexOf(subFrase);
            WriteLine(pos);
            */
            /* se a frase contem determinada string
            var achou = frase.Contains(subFrase);
            WriteLine(achou);
            */
            //WriteLine(frase.Length); // contar caracteres

            /* dividir string 
            string[] partes = frase.Split(",");
            for(var i=0; i < partes.Length;i++)
            {
                WriteLine(partes[i].Trim());
            }
            */
            ReadLine();
        }
    }
}
