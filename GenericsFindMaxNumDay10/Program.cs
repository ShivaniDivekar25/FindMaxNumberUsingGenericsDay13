namespace GenericsFindMaxNumDay10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to find maximum number using Generics Program");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:Find integer maximum number\n2:Find float maximum number\n3:Find maximum for string\n4:Find max using Generic Method\n5:Find max using Generic class\n6:Find max for mutliple parameter\n7:Extended UC4 for printing max number");     
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)             //Calling different methods using switch case for UC3 refacator1, refactor2, UC4
            {
                case 1:     //UC1
                   // MaxNumber.maxNumber();          //Calling method for integer
                    break;
                case 2:     //UC2
                    //MaxNumber.maxNumber1();         //calling method for float
                    break;
                case 3:     //UC3
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
                    }
                    break;    
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
                    }
                    break;
                    
                case 6:
                    {    //UC-4
                        //INTEGER
                        Console.WriteLine("Enter the count of integer number");
                        int count = Convert.ToInt32(Console.ReadLine());
                        int[] numbersInt = new int[count];
                        for (int i = 0; i < count; i++)
                        {
                            numbersInt[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        FindMax<int> obj = new FindMax<int>(numbersInt);
                        obj.MaxMethod();
                        //FLOATS
                        Console.WriteLine("Enter the count of float number");
                        int count1 = Convert.ToInt32(Console.ReadLine());
                        float[] numbersFloat = new float[count1];
                        for (int i = 0; i < count1; i++)
                        {
                            numbersFloat[i] = Convert.ToSingle(Console.ReadLine());
                        }
                        FindMax<float> obj2 = new FindMax<float>(numbersFloat);
                        obj2.MaxMethod();
                        //STRING
                        Console.WriteLine("Enter the count of string");
                        int count2 = Convert.ToInt32(Console.ReadLine());
                        string[] numbersString = new string[count2];
                        for (int i = 0; i < count2; i++)
                        {
                            numbersString[i] = Convert.ToString(Console.ReadLine());
                        }
                        FindMax<string> obj3 = new FindMax<string>(numbersString);
                        obj3.MaxMethod();
                    }
                    break;
                case 7:
                    {   //UC5
                        //INTEGER
                        Console.WriteLine("Enter the count of integer number");
                        int count = Convert.ToInt32(Console.ReadLine());
                        int[] numbersInt = new int[count];
                        for (int i = 0; i < count; i++)
                        {
                            numbersInt[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        FindMax<int> obj = new FindMax<int>(numbersInt);
                        obj.PrintMaxValue();
                        //FLOATS
                        Console.WriteLine("Enter the count of float number");
                        int count1 = Convert.ToInt32(Console.ReadLine());
                        float[] numbersFloat = new float[count1];
                        for (int i = 0; i < count1; i++)
                        {
                            numbersFloat[i] = Convert.ToSingle(Console.ReadLine());
                        }
                        FindMax<float> obj2 = new FindMax<float>(numbersFloat);
                        obj2.PrintMaxValue();
                        //STRING
                        Console.WriteLine("Enter the count of string");
                        int count2 = Convert.ToInt32(Console.ReadLine());
                        string[] numbersString = new string[count2];
                        for (int i = 0; i < count2; i++)
                        {
                            numbersString[i] = Convert.ToString(Console.ReadLine());
                        }
                        FindMax<string> obj3 = new FindMax<string>(numbersString);
                        obj3.PrintMaxValue();
                    }
                    break;
                default:
                    Console.WriteLine("Please enter correct option");
                    break;
            }
        }
    }
}