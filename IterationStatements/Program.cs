namespace IterationStatements
{
    public class Program
    {

        public static void Print1000s()

        {
            //LukeWarm Section: Create methods below
            //Write a method that will print to the console all numbers 1000 through - 1000
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
            //Write a method that will print to the console numbers 3 through 999 by 3 each time

            static void Three()
            {
                for (int i = 3; i <= 999; i += 3)

                {
                    Console.WriteLine(i);
                }
            }

            //Write a method to accept two integers as parameterss and check whether they are equal or not

            static bool Accept(int a, int b)
            {
                if (a == b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                {
                    Console.WriteLine((a == b) ? "Those numbers are equal." : "Those numbers are not equal.");
                }
            }


            //Write a method to check whether a given number is even or odd
            static void OddorEven(int number)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is even.");
                }
                else
                {
                    Console.WriteLine($"{number} IS ODD.");
                }
                //Console.WriteLine((number % 2 == 0) ? $"{number} is even." : $"{number} is odd.";
            }


            //Write a method to check whether a given number is positive or negative
            static void PositiveorNegative(int num)
            {
                if (num < 0)
                {
                    Console.WriteLine($"{num} is positive");
                }
                else if (num < 0)
                {
                    Console.WriteLine($"{num} is negative");
                }
                else
                {
                    Console.WriteLine($"{num} is neither positive nor negative");
                }
                //Console.WriteLine(())
            }
            //Write a method to read the age of a candidate and determine whether they can vote.
            //Hint: Use Parse or the safer TryParse() for an extra challenge
            //Parse()
            //TryParse()

            static void AgeCheck()
            {
                bool userAge;
                int result;

                do
                {
                    Console.WriteLine("Please enter your age:");

                    userAge = int.TryParse(Console.ReadLine(), out result);
                } while (!userAge);

                if (result < 18)
                {
                    Console.WriteLine("you are not old enough to vote");
                }
                else
                {
                    Console.WriteLine("you can vote");
                }
            }


            //Heatin Up Section:
            //Write a method to check if an integer(from the user) is in the range -10 to 10
            static void InRange()
            {
                bool userResponse;
                int result;

                do
                {
                    Console.WriteLine("Enter an integer");
                    userResponse = int.TryParse(Console.ReadLine(), out result);
                } while (!userResponse);
                    if (result >= -10 && result <= 10) ;
                {
                    Console.WriteLine($"{result} is between -10 & 10");
                }
            }

            //Write a method to display the multiplication table(from 1 to 12) of a given integer
            static void MultiTable()
            {
                bool cont;
                int userInput;
                do
                {
                    Console.WriteLine("Enter an Integer");
                    cont = int.TryParse(Console.ReadLine(), out userInput);
                } while (!cont);
                for(var i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"{i} x {userInput} = {i * userInput}");
                }
                   
            }
            
            //Call the methods to test them in the Main method below

            {
                { static void Main(string[] args();
                    Print1000s();
                    Three();
                    Accept(10, 100);
                    OddorEven(20);
                    OddorEven(5);
                    AgeCheck();
                    InRange();
                    MultiTable();
                }
            }
        }
    }
}