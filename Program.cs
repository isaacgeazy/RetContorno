using System;

namespace RetContorno
{
    class Program
    {
        static void Main(string[] args)
        {
           int n1 = 1, n2 = 1, altura, largura;

           Console.Write("Digite a altura: ");
           altura = int.Parse(Console.ReadLine());

           Console.Write("Digite a largura: ");
           largura = int.Parse(Console.ReadLine());

           Console.WriteLine();

           while (n1 <= largura)
            {
                while (n2 <= altura)
                {
                   if (n1 == 1 || n1 == largura || n2 == 1 || n2 == altura)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                   n2++;
                }
                n2 = 1;       
                n1++;
                Console.WriteLine();



                 
            }
        }
    }
}
