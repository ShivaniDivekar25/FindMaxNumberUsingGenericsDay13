namespace GenericsFindMaxNumDay10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to find maximum number using Generics Program");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:Find integer maximum number\n2:Find float maximum number\n3:Find maximum for string\n4:Find max using Generic Method\n 5:Find max using Generic class");     
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)             //Calling different methods using switch case for UC3 refacator1 and refactor2
            {
                case 1:
                   // MaxNumber.maxNumber();          //Calling method for integer
                    break;
                case 2:
                    //MaxNumber.maxNumber1();         //calling method for float
                    break;
                case 3:
                    //MaxNumber.maxNumber2();         //Calling method for string
                    break;
                case 4:
                    {   //Refactor-1 for UC3
                        //INTEGER
                        Console.WriteLine("Enter First Integer Number");
                        int firstInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Second Integer Number");
                        int secondInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Third Integer Number");
                        int thirdInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Max Value:" + FindMax<int>.GenericMaxNumber(firstInt, secondInt, thirdInt));
                        //FLOATS
                        Console.WriteLine("Enter First float Number");
                        float firstFloat = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Enter Second float Number");
                        float secondFloat = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Enter Third float Number");
                        float thirdFloat = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Max Value:" + FindMax<float>.GenericMaxNumber(firstFloat, secondFloat, thirdFloat));
                        // STRINGS
                        Console.WriteLine("Enter First string");
                        string firstString = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter string");
                        string secondString = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter Third string");
                        string thirdString = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Max Value:" + FindMax<string>.GenericMaxNumber(firstString, secondString, thirdString));
                        break;
                    }
                case 5:
                    {  //RefCTOR-2 for UC3
                        //INTEGER
                        Console.WriteLine("Enter First Integer Number");
                        int firstInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Second Integer Number");
                        int secondInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Third Integer Number");
                        int thirdInt = Convert.ToInt32(Console.ReadLine());
                        FindMax<int> obj = new FindMax<int>(firstInt, secondInt, thirdInt);
                        obj.TestMaximum();
                        //FLOATS
                        Console.WriteLine("Enter First float Number");
                        float firstFloat = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Enter Second float Number");
                        float secondFloat = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Enter Third float Number");
                        float thirdFloat = Convert.ToSingle(Console.ReadLine());
                        FindMax<float> obj2 = new FindMax<float>(firstFloat, secondFloat, thirdFloat);
                        obj2.TestMaximum();
                        //STRING
                        Console.WriteLine("Enter First string");
                        string firstString = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter string");
                        string secondString = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter Third string");
                        string thirdString = Convert.ToString(Console.ReadLine());
                        FindMax<string> obj3 = new FindMax<string>(firstString, secondString, thirdString);
                        obj3.TestMaximum();
                        break;
                    }
                default:
                    Console.WriteLine("Please enter correct option");
                    break;
            }
        }
    }
}