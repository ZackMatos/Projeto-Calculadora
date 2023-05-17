using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************\n *Calculadora\n");
            Console.WriteLine("Opções possíveis:\n *1.Adição\n *2.Subtração\n *3.Multiplicação" +
                "\n *4.Divisão\n *5.Sair do Programa\n");
            Console.WriteLine("Entre com sua opção:");
            int escolha = int.Parse(Console.ReadLine());

           

            while (escolha != 1 && escolha != 2 && escolha != 3 && escolha != 4 && escolha !=5)
            {
                Console.WriteLine("\nOpção Inválida, Tente novamente");
                Console.WriteLine("\nEntre com sua opção:");
                escolha = int.Parse(Console.ReadLine());

            }
            while (escolha != 5)
            {
              switch (escolha)
                {
                    case 1:
                        Console.WriteLine("\nDigite um número:");
                        float num = float.Parse(Console.ReadLine());
                        Console.WriteLine("\nDigite outro número:");
                        float num2 = float.Parse(Console.ReadLine());
                        Console.WriteLine($"\nO resultado da soma é: {num + num2}\n");
                        escolha = 0;
                        break;

                   case 2:
                        Console.WriteLine("\nDigite um número:");
                        num = float.Parse(Console.ReadLine());
                        Console.WriteLine("\nDigite outro número:");
                        num2 = float.Parse(Console.ReadLine());
                        Console.WriteLine($"\nO resultado da subtração é: {num - num2}\n");
                        escolha = 0;
                        break;

                  case 3:
                        Console.WriteLine("\nDigite um número:");
                        num = float.Parse(Console.ReadLine());
                        Console.WriteLine("\nDigite outro número:");
                        num2 = float.Parse(Console.ReadLine());
                        Console.WriteLine($"\nO resultado da multiplicação é: {num * num2}\n");
                        escolha = 0;
                        break;

                  case 4:
                        Console.WriteLine("\nDigite um número:");
                        num = float.Parse(Console.ReadLine());
                        Console.WriteLine("\nDigite outro número:");
                        num2 = float.Parse(Console.ReadLine());
                        Console.WriteLine($"\nO resultado da divisão é: {num / num2}\n");
                        escolha = 0;
                        break;
                }
                if (escolha == 0)
                {
                    Console.WriteLine("*********************************\n *Calculadora\n");
                    Console.WriteLine("Opções possíveis:\n *1.Adição\n *2.Subtração\n *3.Multiplicação" +
                        "\n *4.Divisão\n *5.Sair do Programa\n");
                    Console.WriteLine("Entre com sua opção:");
                    escolha = int.Parse(Console.ReadLine());
                }

            }
            if (escolha == 5)
            {
                Console.WriteLine("\nAperte qualquer tecla para sair");
            }





















            Console.ReadKey();
        }
    }
}
