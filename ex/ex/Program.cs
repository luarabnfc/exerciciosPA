using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 1");
            Console.WriteLine("***********");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("OBS: Caso queira encerrar o programa digite 0!!");
            Console.WriteLine();

            int soma = 0;
            int i = 0;
            int num = 1;
            int idade = 0;


            Console.ForegroundColor = ConsoleColor.Gray;

            do
            {
                Console.Write("Digite a " + num + "º idade: ");
                
                idade = Convert.ToInt32(Console.ReadLine());

                if (idade != 0)
                {
                    i++;
                }
                num++;
                soma = soma + idade;

            } while (idade != 0);

            int media = soma / i;

            Console.WriteLine("O Resultado da média das idades é: " + media);
            Console.ReadKey();
        }
    }
}
