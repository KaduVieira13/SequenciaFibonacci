using System;

namespace SequenciaFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
             int num1 = 0, num2 = 1, sequencia,soma;
            bool sequenciaValida;
            string sair;


            do
            {

                Console.WriteLine("----- Sequência Fibonacci -----\n");

                
                Console.Write("Digite a Quantidade de numeros dentro da  sequência: ");
                sequenciaValida = Int32.TryParse(Console.ReadLine(), out sequencia);

                if (!sequenciaValida)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Número inválido!");
                    Console.ResetColor();
                }

                soma = num1 + num2;
               

                for (int i = 0; i < sequencia; i++)
                {
                    Console.Write(soma + " ");
                    soma = num1 + num2;
                    num1 = num2;
                    num2 = soma;
                   
                }

                Console.WriteLine();
                Console.Write("Deseja Sair? S/N: ");
                sair = Console.ReadLine().ToUpper();
            }
            while (sair == "N" || sair == "NAO");
            {
                Console.WriteLine();
                Console.WriteLine("Obrigado por utilizar meu programa!");
            }
        }
    }
}
