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
            UserInteraction.ExecuteFizzBuzz();
            Console.WriteLine("¡Gracias por haber usado la aplicación!");
        }

        public class UserInteraction
        {
            public static void ExecuteFizzBuzz()
            {
                int numStart = 0, numEnd = 0;
                bool valid = false;

                do
                {
                    try
                    {
                        numStart = RequestNumber("Inserte el número inicial para el FizzBuzz");
                        numEnd = RequestNumber("Inserte el número final para el FizzBuzz");
                        valid = ValidateNums(numStart, numEnd);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nADVERTENCIA: El/los valores insertados deben de ser números enteros.\n");
                    }

                } while (!valid);


                PrintArray(FizzBuzz.GenerateSequence(numStart, numEnd));
            }

            public static int RequestNumber(string Text)
            {
                Console.WriteLine(Text);
                return Convert.ToInt32(Console.ReadLine());
            }

            public static void PrintArray(string[] array)
            {
                Console.WriteLine("");
                foreach (string str in array)
                {
                    Console.WriteLine(str);
                }
            }

            public static bool ValidateNums(int NumStart, int NumEnd)
            {
                bool valid = NumStart < NumEnd;
                if (!valid) Console.WriteLine("El número inicial debe de ser menor al número final.\n");
                return valid;
            }
        }

        public class FizzBuzz
        {
            public static string[] GenerateSequence(int NumStart, int NumEnd)
            {
                List<string> resultado = new List<string>();

                for (int i = NumStart; i <= NumEnd; i++)
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
