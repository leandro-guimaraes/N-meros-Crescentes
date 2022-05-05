using System;

namespace Numeros_Crescentes
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero, segundoNumero, terceiroNumero;

            Console.WriteLine("Insira o primeiro numero:  ");
            primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo numero:  ");
            segundoNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o terceiro  numero:  ");
            terceiroNumero = int.Parse(Console.ReadLine());
        
            if(primeiroNumero > segundoNumero && segundoNumero > terceiroNumero)
            {
                Console.WriteLine(primeiroNumero+","+segundoNumero+","+terceiroNumero);
            }

            else
            {
                if (segundoNumero > primeiroNumero && primeiroNumero > terceiroNumero)
                {
                    Console.WriteLine(segundoNumero + "," + primeiroNumero + "," + terceiroNumero);
                }
                else
                {
                    if (terceiroNumero > primeiroNumero && primeiroNumero > segundoNumero)
                    {
                        Console.WriteLine(terceiroNumero+ "," + primeiroNumero + "," + segundoNumero);
                    }
                    else
                    {

                    }
                }

            }

           
        }
       
    }
}