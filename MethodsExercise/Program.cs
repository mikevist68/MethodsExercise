using System.ComponentModel;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {


        public static void Main(string[] args)
        {
            MadLibs();

            int myAddedVariable = Add(2, 2);
            Console.WriteLine(myAddedVariable);

            int mySubtractedVariable = Subtract(2, 2);
            Console.WriteLine(mySubtractedVariable);

            int myMultipliedVariable = Multiply(2, 2);
            Console.WriteLine(myMultipliedVariable);

            int myModulusVariable = Modulus(2, 2);
            Console.WriteLine(myModulusVariable);

            int myDivideVariable = Divide(2, 2);
            Console.WriteLine(myDivideVariable);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }

        public static int Divide(int num1, int num2)
        {
            return (num1 / num2);
        }

        public static void MadLibs() 
        {
            Console.WriteLine("Whats your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Whats your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("Whats your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("Whats your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"Whats your name? {name} Whats your favorite color? {color} Whats your favorite animal? {animal} Whats your favoite band? {band}");

        }
    }   
        
    

}            
       



        
        

    


    

