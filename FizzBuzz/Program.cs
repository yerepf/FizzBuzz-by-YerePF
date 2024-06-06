using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInteraction.EjecutarFizzBuzz();
            Console.WriteLine("¡Gracias por haber usado la aplicación!");
        }

        public class UserInteraction
        {
            public static void EjecutarFizzBuzz()
            {
                int numInicial = 0, numFinal = 0;
                bool valid = false;

                do
                {
                    try
                    {
                        numInicial = RequestNumber("Inserte el número inicial para el FizzBuzz");
                        numFinal = RequestNumber("Inserte el número final para el FizzBuzz");
                        valid = ValidarNums(numInicial, numFinal);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nADVERTENCIA: El/los valores insertados deben de ser números enteros.\n");
                    }

                } while (!valid);


                PrintArray(FizzBuzz.GenerarSecuencia(numInicial, numFinal));
            }

            public static int RequestNumber(string Text)
            {
                Console.WriteLine(Text);
                return Convert.ToInt32(Console.ReadLine());
            }

            public static void PrintArray(string[] array)
            {
                foreach (string str in array)
                {
                    Console.WriteLine(str);
                }
            }

            public static bool ValidarNums(int NumInicial, int NumFinal)
            {
                bool valid = NumInicial < NumFinal;
                if (!valid) Console.WriteLine("El número inicial debe de ser menor al número final.\n");
                return valid;
            }
        }

        public class FizzBuzz
        {
            public static string[] GenerarSecuencia(int numInicial, int numFinal)
            {
                List<string> resultado = new List<string>();

                for (int i = numInicial; i <= numFinal; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0) resultado.Add("FizzBuzz");
                    else if (i % 3 == 0) resultado.Add("Fizz");
                    else if (i % 5 == 0) resultado.Add("Buzz");
                    else resultado.Add(i.ToString());
                }

                return resultado.ToArray();
            }
        }
    }
}
