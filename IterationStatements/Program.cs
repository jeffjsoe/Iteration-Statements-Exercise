//-JESUS
namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {


            Numbers();

            threes();

            //Ask user to enter a number
            Console.WriteLine("Please enter a number");
            //User inputs it into num1
            var num1 = (Console.ReadLine());
            //Whenevr using try.parse method always initialize another variable so that the other variable can go out and esesntialy be assignied that number 
            int number;
            bool isNum = int.TryParse(num1, out number);
            Console.WriteLine("Enter a number");
            var num2 = (Console.ReadLine());
            int number2;
            bool isNum2 = int.TryParse(num2, out number2);
            if (isNum && isNum2)

            {
                var equall = equal(number, number2);
                Console.WriteLine(equall);
            }

            EvenOrOdd();

            NegativeOrPositive();
            Voting();
              static void NegativeOrPositive()
            {
                Console.WriteLine("Please enter a number and I will determine if you are negative or positive");
                var userinput = Console.ReadLine();
                int test;
                //-if it is integer set the value to test
                bool isnumber = int.TryParse(userinput, out test);
                if (isnumber)
                {
                    if (test <= 0)
                    {
                        Console.WriteLine("It is negative");
                    }
                    else
                    {
                        Console.WriteLine("It is postive");
                    }
                }
            }

            //Create a method which will print all the console numbers from 1000 to -1000
            static void Numbers()
            {
                for (int x = 1000; x >= -1000; x--)

                    Console.WriteLine(x);
            }

            static void threes()
            {
                int x = 3;
                do
                {
                    Console.WriteLine(x);

                    x += 3;

                } while (x <= 999);
             }
            static string equal(int input1, int input2)
            {
                if (input1 == input2)
                {
                    return "They are equal";

                }
                else
                {
                    return "THey are not equal";
                 }
            }

            static void EvenOrOdd()
            {

                Console.WriteLine("Please enter a number");
                var number = Console.ReadLine();
                int go;
                //make it a bool to test if it is a number or not
                bool isnum = int.TryParse(number, out go);

                //If this statemtn is true then execute and check if it is true!!!
                if (isnum)
                {
                    if (go % 2 == 0)
                    {
                        Console.WriteLine("It is even"); ;
                     }

                    else
                    {
                        Console.WriteLine("Its Odd");
                     }
                }
            }
            
            static void Voting()
            {
                Console.WriteLine("Please enter your age to determine if you can vote");
                var userVotingAge = Console.ReadLine();


                int ageTest;
                //Now use the TryParse method and see if it is a number and asign to the the variable called agee
                bool isNum = int.TryParse(userVotingAge, out ageTest);

                if (isNum)
                {
                    if (ageTest > 18)
                    {
                        Console.WriteLine("You are old enough to vote");
                     }
                    else
                    {
                        Console.WriteLine("You are too young");
                    }
                 }
            }
        }
    }
}
