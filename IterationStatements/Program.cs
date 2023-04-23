namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000 - DONE!

        //Write a method that will print to the console numbers 3 through 999 by 3 each time - DONE!

        //Write a method to accept two integers as parameters and check whether they are equal or not - DONE!

        //Write a method to check whether a given number is even or odd - DONE!

        //Write a method to check whether a given number is positive or negative - DONE!

        //Write a method to read the age of a candidate and determine whether they can vote. - DONE!
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10 - DONE!

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintThousand();

            PrintThree();

            Console.WriteLine(counterTwo(2, 8));

            isEven(4);

            posNumber(6);

            var userInput = "";
            int age;
            bool proceed;

            do
            {

                Console.WriteLine($"Please enter the age of the person voting");
                userInput = Console.ReadLine();
                proceed = int.TryParse(userInput, out age);

            } while (!proceed);


            OfVotingAge(age);

            Console.WriteLine("");
            Console.WriteLine("Please enter a number");
            var bNum = int.Parse(Console.ReadLine());
            Console.Write(InRangeTen(bNum));

            Console.WriteLine("");
            Console.WriteLine("Multiplication 1-12");
            Console.WriteLine("Please enter a number:");
            TimesTable();
           

        }
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintThree()
        {
            for (int c = 3; c <= 999; c += 3)
            {
                Console.WriteLine(c);
            }
        }
        public static bool counterTwo(int x, int y)
        {
            var check = (x == y) ? true : false;

            return check;
        }
        public static void isEven(int aNumber)
        {
            if (aNumber % 2 == 0)
                Console.WriteLine($"Number is even");
            else
                Console.WriteLine($"Number is odd");
        }
        public static void posNumber(int bNumber)
        {
            if (bNumber > 0)
                Console.WriteLine("Number is positive");

            else
                Console.WriteLine("Number is negative");
        }
        public static bool OfVotingAge(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine($"Congrats! you may vote");
                return true;
            }
            else
            {
                Console.WriteLine($"Sorry, you're too young to vote");
                return false;
            }
        }
        public static bool InRangeTen(int bNum)
        {
            if(bNum <= 10 && bNum >= -10)
            {
                Console.WriteLine("That number is inbetween -10 and 10");
                return true;
            }
            Console.WriteLine("That number is out of range");
            return false;
        }
        public static void TimesTable()
        {
            var yNum = int.Parse(Console.ReadLine());
            int y;
            for(int u = 1; u <= 12; u++)
            {
                y = yNum * u;
                Console.WriteLine("{0} * {1} = {2} \n", yNum, u, yNum * u);
            }
        }
    }    
}
