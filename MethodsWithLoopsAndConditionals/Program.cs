using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Thousand();
            ThreeNine();
            Equality(1, 2);
            EvenOdd(3245);
            AboveZero(-5);
            AgeVote();
            RangeCheck();
            MultTable();
        }
        //Write a method that will print to the console all numbers 1000 through -1000.

        public static void Thousand()
        {
            var i = -1000;
             while (i < 1000) // not <= to 1000 because than the loop would run an extra time after 1000 and increment i giving us 1001
                {
                i++;
                Console.WriteLine(i);
            }
            Console.WriteLine("end of method");
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time.

        public static void ThreeNine()
        {
            for (int i = 3; i <= 999; i+= 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameters and check whether they are equal or not.
        public static void Equality(int a, int b)
        { 
            if (a == b)
            {
                Console.WriteLine($"{a} is equal to {b}"); ;
            }
            else
            {
                Console.WriteLine($"{a} is not equal to {b}");
            }
        }

        //Write a method to check whether a given number is even or odd.

        public static void EvenOdd(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is an even number");
            }
            else
            {
                Console.WriteLine($"{a} is an odd number"); 
            }
        }

        //Write a method to check whether a given number is positive or negative.

        public static void AboveZero(int a)
        {
            if (a >= 0.00)
            {
                Console.WriteLine($"{a} is a positive number");
            }
            else
            {
                Console.WriteLine($"{a} is a negative number");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!

        public static void AgeVote()
        {
            Console.WriteLine("Please enter your age to determine your eligibilty to vote");
            var guess = Convert.ToDouble(Console.ReadLine());
            if (guess >= 18)
            {
                Console.WriteLine("Congratulations, you may vote");
            }
            else
            {
                Console.WriteLine("Sorry, you are too young to vote");
            }
        }

        //Write a method to check if an integer(from the user) is in the range -10 to 10.

        public static void RangeCheck()
        {
            Console.WriteLine("Please enter a number from -10 to 10:");
            var guess = Convert.ToDouble(Console.ReadLine());
            if (guess >= -10 && guess <= 10) // checking if -10 is lower, in other words less than -43 which is technically bigger in being more negative
            {
                Console.WriteLine("Thanks, you're number is in the correct range");
            }
            else
            {
                Console.WriteLine("Sorry, the number you provided is not in the correct range");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer.

        public static void MultTable()
        {
            Console.WriteLine("Please enter any number to multiply from 1 to 12:");
            var guess = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("This is your result:");

            //use a for loop to create numbers 1 - 12 and than multiply them by the users input
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(guess * i);
            }
        }



    }
}
