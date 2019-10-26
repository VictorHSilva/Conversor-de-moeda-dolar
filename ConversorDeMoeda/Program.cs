using System;
using System.Globalization;

namespace ConversorDeMoeda
{
    class Program
    {
        static void Main(string[] args)
        {   // Entra com os dois valores para vlrDolar e qtdDolar
            Console.Write("Qual o valor atual do dólar: ");
            double vlrDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você pretende comprar: ");
            double qtdDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // Variavel vlrPago recebe a classe ConversorDeMoeda mais seu método VlrTotal
            //usando os valores recebidos de entrada vlrDolar,qtdDolar.
            double vlrPago = ConversorDeMoeda.VlrTotal(vlrDolar,qtdDolar);

            Console.Write("O valor que você terá de pagar é: "+ vlrPago.ToString("f2",CultureInfo.InvariantCulture));


        }
    }
}
