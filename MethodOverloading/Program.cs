using System.ComponentModel;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine(Add(0, 1, false));




        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;

        }

        static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        static string Add(int num1, int num2, bool text)
        {
            
            if (text == true && num1 + num2 != 1)
            {
                return $"{num1 + num2} dollars";
            }
            else if (text == true && num1 + num2 == 1)
            {
                return $"{num1 + num2} dollar";
            }
            else
            {
                return $"{num1 + num2}";
            }



        }
    }
}
