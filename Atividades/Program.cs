using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=============================Data e Hora================================= ");
            String date = DateTime.Now.ToString("dd-MM-yyyy");
            String hora = DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine(date);
            Console.WriteLine(hora);

            Console.Title = "Calculadora";
            Console.WriteLine("============================ Calculadora ============================ ");
           
            for (int i = 1; i < 35; i++)
            {
                Console.SetWindowSize(i, i);
                System.Threading.Thread.Sleep(20);
            }

            string operacao;
            decimal valor1; List<string> lista1;
            lista1 = new List<string>(); List<decimal> lista2;
            lista2 = new List<decimal>(); valor1 = isNumero();
            do
            {
                Console.WriteLine($"Digite uma operação( + | - | * | / : ");
                operacao = Console.ReadLine();
            }
            while (operacao != "+" && operacao != "-"
                        && operacao != "*" && operacao != "/");
            lista1.Add(operacao);
            do
            {
                valor1 = isNumero();
                if (valor1 == 0 && operacao == "/")
                {
                    Console.WriteLine("Não é possivel dividir por 0.");
                }
            } while (valor1 != 0); lista1.Add(operacao);
        }

        public static decimal isNumero()
        {
            string entrada;
            decimal isNumero;
            bool valido;

            do
            {
                Console.WriteLine($"Digite um número:");
                entrada = Console.ReadLine();
                valido = decimal.TryParse(entrada, out isNumero);
                if (!valido)
                {
                    Console.WriteLine("Digite um número válido.");
                }
            }
            while (!valido);
            return isNumero;
        }
    }
}
