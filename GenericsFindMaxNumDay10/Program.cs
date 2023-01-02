namespace GenericsFindMaxNumDay10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to find maximum number using Generics Program");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:Find integer maximum number\n2:Find float maximum number\n3:Find maximum for string");     
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)             //Calling different methods using switch case for UC1 and UC2
            {
                case 1:
                    MaxNumber.maxNumber();          //Calling method for integer
                    break;
                case 2:
                    MaxNumber.maxNumber1();         //calling method for float
                    break;
                case 3:
                    MaxNumber.maxNumber2();         //Calling method for string
                    break;
                default:
                    Console.WriteLine("Please enter correct option");
                    break;
            }
        }
    }
}