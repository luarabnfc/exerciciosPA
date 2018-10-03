using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 2");
            Console.WriteLine("***********");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("OBS: Caso queira encerrar o prrograma digite -1!!");
            Console.WriteLine();

            int i = 0;
            int num = 1;
            double soma = 0;
            double nota = 0;
            Console.ForegroundColor = ConsoleColor.Gray;
            do
            {
                Console.Write("Digite a " + num + "º nota: ");
                nota = Convert.ToDouble(Console.ReadLine());
                if( nota != -1)
                {
                    i++;
                    soma = soma + nota;
                }
                
                num++;
               

            }while(nota != -1);
            
            double media = soma / i;

            Console.WriteLine("A média das notas é: " + media);
            Console.ReadKey();
        }
    }
}
