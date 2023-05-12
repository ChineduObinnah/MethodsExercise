using System.Threading.Channels;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Story();
            Console.WriteLine(Add(5, 5));
         
            Console.WriteLine(Subtract(5, 5));
            
            Console.WriteLine(Divide(5, 5));

            Console.WriteLine(Multiply(5, 5));

            Console.WriteLine(Modulus(5, 5));
        }

        public static void Story()
        {
            Console.WriteLine("Hello, Whats your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Nice to meet you {name} ");
            Console.WriteLine("What is your favorite color");
            string color = Console.ReadLine();
            Console.WriteLine("That's great!");
            Console.WriteLine("What is your favorite animal");
            string animal = Console.ReadLine();
            Console.WriteLine("That's Cool!");
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine($"One day {name} was walking through the woods in a {color} shirt and saw a {animal} that was listining to {band}");

        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Multiply(in int num1, in int num2)
        {
            return num1 * num2;
        }
        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }
    }

}
