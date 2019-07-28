using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            ex4();
        }
        static void ex1()
        {
            int[] numeros = new int[100];
            int quant = numeros.Length;
            for (int i = 0; i < quant; i++)
            {
                numeros[i] = i; 
            }
            foreach (var item in numeros)
            {
                Console.WriteLine("Valor é "+item);
            }
            Console.ReadLine();
        }
        static void ex2()
        {
            Console.WriteLine("Digite a quantidade de números do array: ");
            int quant = int.Parse(Console.ReadLine());
            int[] numeros = new int[quant];
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] <= numeros.Length)
                {
                    Console.WriteLine("Digite o número para adicionar no Array:");
                    int aux = int.Parse(Console.ReadLine());
                    numeros[i] = aux;
                }
            }
            foreach (var item in numeros)
            {
                Console.Write(" " + item + " ");
            }
            Console.ReadLine();
        }
        static void ex3()
        {
            Console.WriteLine("Digite: ");
            string txt = Console.ReadLine();
            for (int i = 0; i < txt.Length; i++)
            {
                if ((txt[i] >= '0') && (txt[i] <= '9'))
                {
                    char caracter = txt[i];
                    Console.WriteLine("E numeral: " + caracter);
                }
            }
            Console.ReadLine();
        }
        static void ex4()
        {
            int[] numeros = new int[] { 5, 4, 6, 1, 3, 9, 10, 50 };
            int quant_numeros = numeros.Length;
            for (int i = 1; i < quant_numeros; i++)
            {
                for (int j = 0; j < quant_numeros; j++)
                {
                    int aux = numeros[i];
                    if (numeros[i] <= numeros[j])
                    {
                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                    }
                }
            }
            int maior = numeros[quant_numeros - 1];
            int menor = numeros[0];
            Console.WriteLine("Maior é "+maior);
            Console.WriteLine("Menor é " + menor);
            Console.ReadLine();
        }
        static void ex5()
        {
            int[] numeros = new int[] { 100, 50, 8, 5, 4, 6, 1, 3, 9 };
            int quant_numeros = numeros.Length;
            for (int i = 1; i < quant_numeros; i++)
            {
                for (int j = 0; j < quant_numeros; j++)
                {
                    int aux = numeros[i];
                    if (numeros[i] < numeros[j])
                    {
                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                    }
                }
            }
            foreach (var item in numeros)
            {
                Console.Write(" " + item + " ");
            }
            Console.ReadLine();
        }
    }
}
