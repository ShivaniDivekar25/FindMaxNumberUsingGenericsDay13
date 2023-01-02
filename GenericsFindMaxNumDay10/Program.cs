namespace GenericsFindMaxNumDay10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to find maximum number using Generics Program");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:Find integer maximum number");     
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)             //Calling different methods using switch case
            {
                case 1:
                    MaxNumber.maxNumber();
                    break;
                default:
                    Console.WriteLine("Please enter correct option");
                    break;
            }
        }
    }
}