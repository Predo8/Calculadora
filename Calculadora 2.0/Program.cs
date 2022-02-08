using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace Calculadora
{
    //class Calc
    //{

    //    public static decimal Soma(decimal valor1, decimal valor2)
    //    { return valor1 + valor2; }
    //    public static decimal Subtracao(decimal valor1, decimal valor2)
    //    { return valor1 - valor2; }
    //    public static decimal Multiplicacao(decimal valor1, decimal valor2)
    //    { return valor1 * valor2; }
    //    public static decimal Divisao(decimal valor1, decimal valor2)
    //{ return valor1 / valor2; }

    class Program
    {
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

        static void Main(string[] args)
        {
            string repetir = "s";
            while (repetir == "s")
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("==============Data e Hora================== ");
                String date = DateTime.Now.ToString("dd-MM-yyyy");
                String hora = DateTime.Now.ToString("HH:mm:ss");
                Console.WriteLine(date);
                Console.WriteLine(hora);

                Console.Title = "Calculadora";
                Console.WriteLine("============ Calculadora ================== ");

                for (int i = 1; i < 35; i++)
                {
                    Console.SetWindowSize(i, i);
                    System.Threading.Thread.Sleep(20);
                }
                
                string repetirOp = "s", operacao;
                decimal valor1, valor2, resultado = 0;
                List<string> listaOperacao;
                listaOperacao = new List<string>();
                List<decimal> listaNumero;
                listaNumero = new List<decimal>();
                valor1 = isNumero();
                listaOperacao.Add("+");
                listaNumero.Add(valor1);
                while (repetirOp == "s")
                {
                    do
                    {
                        Console.WriteLine("Digite a operação( + | - | * | / ):");
                        operacao = Console.ReadLine();

                    } while (operacao != "+" && operacao != "-"
                    && operacao != "*" && operacao != "/");
                    listaOperacao.Add(operacao); do
                    {
                        valor2 = isNumero();
                        if (valor2 == 0 && operacao == "/")
                        {
                            Console.WriteLine("Não é possivel dividir por 0.");
                        }
                    } while (valor2 == 0 && operacao == "/");
                    listaNumero.Add(valor2);

                    do
                    {
                        Console.WriteLine("Deseja continuar(S/N):");
                        repetirOp = Console.ReadLine().ToLower();
                    }
                    while (repetirOp != "s" && repetirOp != "n");
                }
                decimal K = 0;
                for (int i = 0; i < listaNumero.Count(); i++)
                {
                    string x = listaOperacao[i];
                    decimal y = listaNumero[i];
                    if (x == "+")
                    {
                        K += y;
                    }
                    else if (x == "-")
                    {
                        K -= y;
                    }
                    else if (x == "/")
                    {
                        K /= y;
                    }
                    else if (x == "*")
                    {
                        K *= y;
                    }
                }
                //foreach (var lista in listaOperacao)
                //{
                //    Console.Write(lista);
                //}
                Console.WriteLine("O resultado é: {0}", K);
                Console.WriteLine("Deseja recomeçar? (S/N)");
                repetir = Console.ReadLine().ToLower().Trim();
                if (repetir == "s")
                {
                    listaOperacao.Clear();
                    listaNumero.Clear();
                    Console.Clear();
                }
                while (repetir != "s" && repetir != "n") ;
            }
        }
    }
}
