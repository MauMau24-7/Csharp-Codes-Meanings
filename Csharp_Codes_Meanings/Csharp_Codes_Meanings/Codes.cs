// strg + K -> strg + C = comment marked, strg + K -> strg + U = uncomment marked

// 1. Tutorial start

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("I like pizza!");
//            Console.WriteLine("It's really good!");
//            Console.Beep();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 2. Output

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Hey!");                  // No new line
//            Console.WriteLine("Hello!");            // A new line afterwards

//            // This is a comment
//            /*
//             * this
//             * is
//             * a
//             * multiline
//             * comment
//             */

//            Console.WriteLine("\tBlaze");

//            Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 3. Variables

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int x;          // declaration
//            x = 123;        // initialisation

//            int y = 321;    // declaration + initialisation

//            int z = x + y;

//            int age = 17;           // whole integer
//            double height = 300.5;  // decimal number
//            bool alive = true;      // true or false
//            char symbol = '@';
//            String name = "Blaze";


//            Console.WriteLine(x);
//            Console.WriteLine(y);
//            Console.WriteLine(z);

//            Console.WriteLine("Hello " + name);
//            Console.WriteLine("Your age is " + age);
//            Console.WriteLine("Your height is " + height + "cm");
//            Console.WriteLine("Are you alive? " + alive);
//            Console.WriteLine("Your symbol is: " + symbol);

//            String userName = symbol + name;

//            Console.WriteLine("Your username is: " + userName);

//            Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 3. Constants π

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // constants =  immutable values which are known at compile time
//            //              and do not change for the life of the program

//            const double pi = 3.14159;

//            Console.WriteLine(pi);

//            Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 5. Type casting

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // type casting =   Converting a value to a different data type
//            //                  Useful when we accept user input (string)
//            //                  Different data types can do different things

//            double a = 3.14;
//            int b = Convert.ToInt32(a);

//            int c = 123;
//            double d = Convert.ToDouble(c);

//            int e = 321;
//            String f = Convert.ToString(e);

//            String g = "$";
//            char h = Convert.ToChar(g);

//            String i = "true";
//            bool j = Convert.ToBoolean(i);

//            Console.WriteLine(a.GetType());
//            Console.WriteLine(a);
//            Console.WriteLine(b.GetType());
//            Console.WriteLine(b);
//            Console.WriteLine(d.GetType());
//            Console.WriteLine(d);
//            Console.WriteLine(f.GetType());
//            Console.WriteLine(f);
//            Console.WriteLine(h.GetType());
//            Console.WriteLine(h);
//            Console.WriteLine(j.GetType());
//            Console.WriteLine(j);

//            Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 6. User input

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("What's your name?");
//            String name = Console.ReadLine();

//            Console.WriteLine("What's your age?");
//            int age = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Hello " + name);
//            Console.WriteLine("You are " + age + " years old");

//            Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 7. arithmetic operators

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int friends = 10;

//            //friends = friends + 2;
//            //friends += 2;
//            //friends++;

//            //friends = friends - 1;
//            //friends -= 1;
//            //friends--;

//            //friends = friends * 2;
//            //friends *= 2;

//            //friends = friends / 2;
//            //friends /= 2;

//            int remainder = friends % 2;


//            //Console.WriteLine(friends);
//            Console.WriteLine(remainder);

//            Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 8. Math class

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            double x = 3.99;
//            double y = 5;

//            //double a = Math.Pow(x, 3);
//            //double b = Math.Sqrt(x);
//            //double c = Math.Abs(x);
//            //double d = Math.Round(x);
//            //double e = Math.Ceiling(x);
//            //double f = Math.Floor(x);
//            //double g = Math.Max(x, y);
//            //double h = Math.Min(x, y);

//            //Console.WriteLine(a);
//            //Console.WriteLine(b);
//            //Console.WriteLine(c);
//            //Console.WriteLine(d);
//            //Console.WriteLine(e);
//            //Console.WriteLine(f);
//            //Console.WriteLine(g);
//            //Console.WriteLine(h);

//            Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 9. Random numbers

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Random random = new Random();

//            int num1 = random.Next(1, 7);
//            int num2 = random.Next(1, 7);
//            int num3 = random.Next(1, 7);

//            //double num = random.NextDouble();

//            Console.WriteLine(num1);
//            Console.WriteLine(num2);
//            Console.WriteLine(num3);


//            Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 10. Hypotenuse calculator programm

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("Enter side A: ");
//            double a = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Enter side B: ");
//            double b = Convert.ToDouble(Console.ReadLine());

//            double c = Math.Sqrt(a * a + b * b);

//            Console.WriteLine("The hypotenuse is: " + c);

//            Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 11. String methods

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            String fullName = "Blaze MauMau";
//            String phoneNumber = "123-456-7890";

//            //fullName = fullName.ToUpper();
//            //fullName = fullName.ToLower();
//            //Console.WriteLine(fullName);

//            //phoneNumber = phoneNumber.Replace("-", "/");
//            //Console.WriteLine(phoneNumber);

//            //String userName = fullName.Insert(0, "Mr. ");
//            //Console.WriteLine(userName);

//            //Console.WriteLine(fullName.Length);

//            //String firstName = fullName.Substring(0, 5);
//            //String lastName = fullName.Substring(6, 6);

//            //Console.WriteLine(firstName);
//            //Console.WriteLine(lastName);

//            Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 12. if statements

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // if statement = a basic form of decision making

//            //Console.WriteLine("Please enter your age: ");
//            //int age = Convert.ToInt32(Console.ReadLine());

//            //if (age > 100)
//            //{
//            //    Console.WriteLine("You are too old to sign up!");
//            //}
//            //else if (age >= 18)
//            //{
//            //    Console.WriteLine("You are now signed up!");
//            //}
//            //else if (age < 0)
//            //{
//            //    Console.WriteLine("You haven't been born yet!");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("You must be 18+ to sign up!");
//            //}


//            //Console.WriteLine("Please enter your name: ");
//            //String name = Console.ReadLine();

//            //if (name == "")
//            //{
//            //    Console.WriteLine("You did not enter your name!");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Hello " + name);
//            //}

//                Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 13. Switches

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // switch = an efficient alternative to many else if statements

//            Console.WriteLine("What day is it today?");
//            String day = Console.ReadLine();

//            switch (day)
//            {
//                case "Monday":
//                    Console.WriteLine("It's Monday!");
//                    break;
//                case "Tuesday":
//                    Console.WriteLine("It's Tuesday!");
//                    break;
//                case "Wednesday":
//                    Console.WriteLine("It's Wednesday!");
//                    break;
//                case "Thursday":
//                    Console.WriteLine("It's Thursday!");
//                    break;
//                case "Friday":
//                    Console.WriteLine("It's Friday!");
//                    break;
//                case "Saturday":
//                    Console.WriteLine("It's Saturday!");
//                    break;
//                case "Sunday":
//                    Console.WriteLine("It's Sunday!");
//                    break;
//                default:
//                    Console.WriteLine(day + " is not a day!");
//                    break;
//            }

//            Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 14. logical operators

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // logical operators = Can be used to check if more than 1 condition is true/false

//            // && (AND)
//            // || (OR)

//            Console.WriteLine("What's the temperature outside: (C)");
//            double temp = Convert.ToDouble(Console.ReadLine());

//            if (temp >= 10 && temp <= 25)
//            {
//                Console.WriteLine("It's warm outside!");
//            }
//            else if (temp <= -50 || temp >= 50)
//            {
//                Console.WriteLine("DO NOT GO OUTSIDE!");
//            }


//                Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 15. while loops

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // while loop = repeats some code while some condition remains true

//            String name = "";

//            while (name == "")
//            {
//                Console.Write("Enter your name: ");
//                name = Console.ReadLine();
//            }

//            //while (1 == 1)
//            //{
//            //    Console.Write("HELP! I'M STUCK IN AN INFINITE LOOP!");          // infite loop because no exit
//            //}

//            Console.WriteLine("Hello " + name);

//            Console.ReadKey();
//        }
//    }
//}

// 16. for loops

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // for loop = repeats some code a FINITE amount of times

//            //for (int i = 1; i <= 10; i++)
//            //{
//            //    Console.WriteLine(i);
//            //}

//            //for (int i = 10; i > 0; i--)
//            //{
//            //    Console.WriteLine(i);
//            //}
//            //Console.WriteLine("HAPPY NEW YEAR!");

//            Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 17. nested loops

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // nested loops =   loops inside of other loops
//            //                  Uses vary. Used a lot in sorting algorithms


//            Console.Write("How many rows?: ");
//            int rows = Convert.ToInt32(Console.ReadLine());

//            Console.Write("How many columns?: ");
//            int columns = Convert.ToInt32(Console.ReadLine());

//            Console.Write("What symbol?: ");
//            String symbol = Console.ReadLine();

//            for (int i = 0; i < rows; i++)
//            {
//                for (int j = 0; j < columns; j++)
//                {
//                    Console.Write(symbol);
//                }
//                Console.WriteLine();
//            }

//            Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 18. number guessing game

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Random random = new Random();
//            bool playAgain = true;
//            int min = 1;
//            int max = 100;
//            int guess;
//            int number;
//            int guesses;
//            String response;

//            while (playAgain)
//            {
//                guess = 0;
//                guesses = 0;
//                response = "";
//                number = random.Next(min, max + 1);

//                while (guess != number)
//                {
//                    Console.WriteLine("Guess a number between " + min + " - " + max + ": ");
//                    guess = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine("Guess: " + guess);

//                    if (guess > number)
//                    {
//                        Console.WriteLine(guess + " is too high!");
//                    }
//                    else if (guess < number)
//                    {
//                        Console.WriteLine(guess + " is too low!");
//                    }
//                    guesses++;
//                }
//                Console.WriteLine("Number: " + number);
//                Console.WriteLine("YOU WIN!");
//                Console.WriteLine("Guesses: " + guesses);

//                Console.WriteLine("Would you like to play again (Y/N): ");
//                response = Console.ReadLine();
//                response = response.ToUpper();

//                if (response == "Y")
//                {
//                    playAgain = true;
//                }
//                else
//                {
//                    playAgain= false;
//                }
//            }

//            Console.WriteLine("Thanks for playing! ... I guess");

//            Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 19. rock-paper-scissors game

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Random random = new Random();
//            bool playAgain = true;
//            String player;
//            String computer;
//            String answer;

//            while (playAgain)
//            {
//                player = "";
//                computer = "";
//                answer = "";

//                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
//                {
//                    Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
//                    player = Console.ReadLine();
//                    player = player.ToUpper();

//                }

//                switch (random.Next(1, 4))
//                {
//                    case 1:
//                        computer = "ROCK";
//                        break;
//                    case 2:
//                        computer = "PAPER";
//                        break;
//                    case 3:
//                        computer = "SCISSORS";
//                        break;
//                }

//                Console.WriteLine("Player: " + player);
//                Console.WriteLine("Computer: " + computer);

//                switch (player)
//                {
//                    case "ROCK":
//                        if (computer == "ROCK")
//                        {
//                            Console.WriteLine("It's a draw!");
//                        }
//                        else if (computer == "PAPER")
//                        {
//                            Console.WriteLine("You lose!");
//                        }
//                        else
//                        {
//                            Console.WriteLine("You win!");
//                        }
//                            break;
//                    case "PAPER":
//                        if (computer == "ROCK")
//                        {
//                            Console.WriteLine("You win!");
//                        }
//                        else if (computer == "PAPER")
//                        {
//                            Console.WriteLine("It's a draw!");
//                        }
//                        else
//                        {
//                            Console.WriteLine("You lose!");
//                        }
//                        break;
//                    case "SCISSORS":
//                        if (computer == "ROCK")
//                        {
//                            Console.WriteLine("You lose!");
//                        }
//                        else if (computer == "PAPER")
//                        {
//                            Console.WriteLine("You win!");
//                        }
//                        else
//                        {
//                            Console.WriteLine("It's a draw!");
//                        }
//                        break;
//                }

//                Console.Write("Would you like to play again (Y/N): ");
//                answer = Console.ReadLine();
//                answer = answer.ToUpper();

//                if (answer == "Y")
//                {
//                    playAgain = true;
//                }
//                else
//                {
//                    playAgain = false;
//                }
//            }

//            Console.WriteLine("Thanks for playing!");

//            Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 20. calculator program

using System;

namespace Csharp_Codes_Meanings
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

            do
            {


                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");

                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an option: ");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }
                Console.WriteLine("Would You like to continue? (Y = yes, N = no): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }
}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 21. arrays

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // array = a variable that can store multiple values. fixed size

//            String[] cars = new string[3];

//            //String[] cars = { "BMW", "Mustang", "Corvette"};

//            cars[0] = "Tesla";
//            cars[1] = "Mustang";
//            cars[2] = "Corvette";

//            for (int i = 0; i < cars.Length; i++)
//            {
//                Console.WriteLine(cars[i]);
//            }

//            Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 22. foreach loop

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // foreach loop = a simpler way to iterate over an array, but it's less flexible

//            String[] cars = { "BMW", "Mustang", "Corvette" };

//            foreach (String car in cars)
//            {
//                Console.WriteLine(car);
//            }


//            Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 23. methods

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // method = performs a section of code, whenever it's called "invoked".
//            //          benefit = Let's us reuse code w/o writing it multiple times

//            String name = "Blaze";
//            int age = 17;

//            singHappyBirthday(name, age);

//            Console.ReadKey();
//        }
//        static void singHappyBirthday(String birthdayBOY, int yearsOld)
//        {
//            Console.WriteLine("Happy birthday to you!");
//            Console.WriteLine("Happy birthday to you!");
//            Console.WriteLine("Happy birthday dear " + birthdayBOY);
//            Console.WriteLine("You are " + yearsOld + " years old!");
//            Console.WriteLine("Happy birthday to you!");
//            Console.WriteLine();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 24. return keyword

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // return = returns data back to the place where a method is invoked

//            double x;
//            double y;
//            double result;

//            Console.WriteLine("Enter in number 1: ");
//            x = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Enter in number 2: ");
//            y = Convert.ToDouble(Console.ReadLine());

//            result = Multiply(x, y);

//            Console.WriteLine(result);

//            Console.ReadKey();
//        }
//        static double Multiply(double x, double y)
//        {
//            return x * y;
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 25. method overloading

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // method overloading = methods share same name, but different parameters
//            //                      name + parameter = signature
//            //                      methods must have a unique signature

//            double total;

//            total = Multiply(2, 3, 4);

//            Console.WriteLine(total);
//            Console.ReadKey();
//        }
//        static double Multiply(double a, double b)
//        {
//            return a * b;
//        }
//        static double Multiply(double a, double b, double c)
//        {
//            return a * b * c;
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 26. params keyword

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // params keyword = a method parameter that takes a variable number of arguments.
//            //                  The parameter type must be a single - dimension array

//            double total = CheckOut(3.99, 5.75, 15, 1.00, 10.25);

//            Console.WriteLine(total);
//            Console.ReadKey();
//        }
//        static double CheckOut(params double[] prices)
//        {
//            double total = 0;

//            foreach (double price in prices)
//            {
//                total += price;
//            }

//            return total;
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 27. exception handling

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // exception = errors that occur during execution 

//            //      try     = try some code that is considered "dangerous"
//            //      catch   = catches and handles exceptions when they occur
//            //      finally = always executes regardless if exception is caught or not

//            double x;
//            double y;
//            double result;

//            try
//            {
//                Console.Write("Enter number 1: ");
//                x = Convert.ToInt32(Console.ReadLine());

//                Console.Write("Enter number 2: ");
//                y = Convert.ToInt32(Console.ReadLine());

//                result = x / y;

//                Console.WriteLine("result: " + result);
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("Enter ONLY numbers PLEASE!");
//            }
//            catch (DivideByZeroException)
//            {
//                Console.WriteLine("You can't divide by zero! IDIOT!");
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("Something went wrong!");
//            }
//            finally
//            {
//                Console.WriteLine("Thanks for visiting!");
//            }
//            Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 28. conditional operator

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // conditional operator = used in conditional assignment if a condition is true/false

//            // (condition) ? x : y

//            double temperature = 20;
//            String message;

//            //if (temperature >= 15)
//            //{
//            //    message = "It's warm outside!";
//            //}
//            //else
//            //{
//            //    message = "It's cold outside";
//            //}

//            //Console.WriteLine(message);

//            message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";

//            Console.WriteLine(message);

//            Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 29. string interpolation

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // string interpolation =   allows us to insert variables into a string literal
//            //                          precede a string literal with $
//            //                          {} are placeholders

//            String firstName = "Blaze";
//            String lastName = "MauMau";
//            int age = 17;

//            //Console.WriteLine("Hello " + firstName + " " + lastName + ".");
//            //Console.WriteLine("You are " + age + " years old.");

//            Console.WriteLine($"Hello {firstName} {lastName}.");
//            Console.WriteLine($"You are {age, -10} years old.");

//            Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 30. multidimensional arrays

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            String[,] parkingLot =  {   { "Mustang", "F-150", "Explorer" },
//                                        { "Corvette", "Camaro", "Silverado" },
//                                        { "Corolla", "Camry", "Rav4" }
//                                    };

//            parkingLot[0, 2] = "Fusion";
//            parkingLot[2, 0] = "Tacoma";

//            //foreach (String car in parkingLot)
//            //{
//            //    Console.WriteLine(car);
//            //}

//            for (int i = 0; i < parkingLot.GetLength(0); i++)
//            {
//                for (int j = 0; j < parkingLot.GetLength(1); j++)
//                {
//                    Console.Write(parkingLot[i, j] + " ");
//                }
//                Console.WriteLine();
//            }


//                    Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 31. classes

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // class =  A bundle of related code.
//            //          Can be used as a blueprint to create objects (OOP)

//            Messages.Hello();
//            Messages.Waiting();
//            Messages.Bye();

//            Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 31. objects

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // object = An instance of a class
//            //          A class can be used as a blueprint to create objects (OOP)
//            //          objects can have fields & methods (characteristics & actions)

//            Human human1 = new Human();
//            Human human2 = new Human();

//            human1.name = "Rick";
//            human1.age = 65;

//            human2.name = "Morty";
//            human2.age = 16;

//            human1.Eat();
//            human1.Sleep();

//            human2.Eat();
//            human2.Sleep();

//            Console.ReadKey();
//        }
//    }
//    class Human
//    {
//        public String name;
//        public int age;

//        public void Eat()
//        {
//            Console.WriteLine(name + " is eating");
//        }
//        public void Sleep()
//        {
//            Console.WriteLine(name + " is sleeping");
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 33. constructors

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // constructor =    A special method in a class
//            //                  Same name as the class name
//            //                  Can be used to assign arguments to fields when creating an object

//            Car car1 = new Car("Ford", "Mustang", 2022, "red");
//            Car car2 = new Car("Chevy", "Corvette", 2021, "blue");

//            car1.Drive();
//            car2.Drive();

//            Console.ReadKey();
//        }
//    }
//    class Car
//    {
//        String make;
//        String model;
//        int year;
//        String color;

//        public Car(String make, String model, int year, String color)
//        {
//            this.make = make;
//            this.model = model;
//            this.year = year;
//            this.color = color;
//        }
//        public void Drive()
//        {
//            Console.WriteLine("You drive the " + make + " " + model);
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 34. static

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // static = modifier to declare a static member, which belongs to the class itself
//            //          rather than to any specific object

//            Car car1 = new Car("Mustang");
//            Car car2 = new Car("Corvette");
//            Car car3 = new Car("Lambo");

//            Console.WriteLine(Car.numberOfCars);

//            Car.StartRace();

//            Console.ReadKey();
//        }
//    }
//    class Car
//    {
//        String model;
//        public static int numberOfCars;
//        public Car(String model)
//        {
//            this.model = model;
//            numberOfCars++;
//        }

//        public static void StartRace()
//        {
//            Console.WriteLine("The race has begun!");
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 35. overload constructors

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // overload constructors =  technique to create multiple constructors
//            //                          with a different set of parameters.
//            //                          name + parameters = signature

//            Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella");



//            Console.ReadKey();
//        }
//    }
//    class Pizza
//    {
//        String bread;
//        String sauce;
//        String cheese;
//        String topping;

//        public Pizza(String bread)
//        {
//            this.bread = bread;
//        }
//        public Pizza(String bread, String sauce)
//        {
//            this.bread = bread;
//            this.sauce = sauce;
//        }
//        public Pizza(String bread, String sauce, String cheese)
//        {
//            this.bread = bread;
//            this.sauce = sauce;
//            this.cheese = cheese;
//        }
//        public Pizza(String bread, String sauce, String cheese, String topping)
//        {
//            this.bread = bread;
//            this.sauce = sauce;
//            this.cheese = cheese;
//            this.topping = topping;
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 36. inheritance

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // inheritance = 1 or more child classes receiving fields, methods, etc. from a common parent

//            Car car = new Car();
//            Bicycle bicycle = new Bicycle();
//            Boat boat = new Boat();

//            Console.WriteLine(car.speed);
//            Console.WriteLine(car.wheels);
//            car.go();

//            Console.WriteLine(bicycle.speed);
//            Console.WriteLine(bicycle.wheels);
//            bicycle.go();

//            Console.WriteLine(boat.speed);
//            Console.WriteLine(boat.wheels);
//            boat.go();

//            Console.ReadKey();
//        }
//    }
//    class Vehicle
//    {
//        public int speed = 0;

//        public void go()
//        {
//            Console.WriteLine("This vehicle is moving!");
//        }
//    }
//    class Car : Vehicle
//    {
//        public int wheels = 4;
//    }
//    class Bicycle : Vehicle
//    {
//        public int wheels = 2;
//    }
//    class Boat : Vehicle
//    {
//        public int wheels = 0;
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 37. abstract classes

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // abstract classes = modifier that indicates missing components or incomplete implementation

//            Car car = new Car();
//            Bicycle bicycle = new Bicycle();
//            Boat boat = new Boat();
//            Vehicle vehicle = new Vehicle();

//            Console.ReadKey();
//        }
//    }
//    abstract class Vehicle
//    {
//        public int speed = 0;

//        public void go()
//        {
//            Console.WriteLine("This vehicle is moving!");
//        }
//    }
//    class Car : Vehicle
//    {
//        public int wheels = 4;
//        int maxSpeed = 500;
//    }
//    class Bicycle : Vehicle
//    {
//        public int wheels = 2;
//        int maxSpeed = 50;
//    }
//    class Boat : Vehicle
//    {
//        public int wheels = 0;
//        int maxSpeed = 100;
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 38. array of objects

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");


//            Car[] garage = { new Car("Mustang"), new Car("Corvette"), new Car("Lambo") };

//            foreach (Car car in garage)
//            {
//                Console.WriteLine(car.model);
//            }

//            Console.ReadKey();
//        }
//    }
//    class Car
//    {
//        public String model;
//        public Car(String model)
//        {
//            this.model = model;
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 39. objects as arguments

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            Car car1 = new Car("Mustang", "red");

//            Car car2 = Copy(car1);

//            //ChangeColor(car1, "silver");
//            //Console.WriteLine(car1.color + " " + car1.model);

//            Console.WriteLine(car2.color + " " + car2.model);

//            Console.ReadKey();
//        }

//        //public static void ChangeColor(Car car, String color)
//        //{
//        //    car.color = color;
//        //}
//        public static Car Copy(Car car)
//        {
//            return new Car(car.model, car.color);
//        }
//    }
//    class Car
//    {
//        public String model;
//        public String color;
//        public Car(String model, String color)
//        {
//            this.model = model;
//            this.color = color;
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 40. method overriding

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // method overriding =  provides a new version of a method inherited from a parent class
//            //                      inherited method must be: abstract, virtual, or already overriden
//            //                      Used with ToString(), polymorphism

//            Dog dog = new Dog();
//            Cat cat = new Cat();

//            dog.Speak();
//            cat.Speak();

//            Console.ReadKey();
//        }
//    }
//    class Animal
//    {
//        public virtual void Speak()
//        {
//            Console.WriteLine("The animal goes *brrr*");
//        }
//    }
//    class Dog : Animal
//    {
//        public override void Speak()
//        {
//            Console.WriteLine("The dog goes *woof*");
//        }
//    }
//    class Cat : Animal
//    {
//        public override void Speak()
//        {
//            Console.WriteLine("The cat goes *meow*");
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 41. ToString method

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // ToString() = converts an object to its string represantation so that it is suitable for display

//            Car car = new Car("Chevy", "Corvette", 2022, "blue");

//            Console.WriteLine(car);

//            Console.ReadKey();
//        }
//    }
//    class Car
//    {
//        String make;
//        String model;
//        int year;
//        String color;

//        public Car(String make, String model, int year, String color)
//        {
//            this.make = make;
//            this.model = model;
//            this.year = year;
//            this.color = color;
//        }
//        public override string ToString()
//        {
//            return "This is a " + make + " " + model;
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 42. polymorphism

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // polymorphism =   Greek word that means to "have many forms"
//            //                  Objects can be identified by more than one type
//            //                  Ex. a Dog is also: Canine, Animal, Organism

//            Car car = new Car();
//            Bicycle bicycle = new Bicycle();
//            Boat boat = new Boat();

//            Vehicle[] vehicles = { car, bicycle, boat };

//            foreach (Vehicle vehicle in vehicles)
//            {
//                vehicle.Go();
//            }

//            Console.ReadKey();
//        }
//    }
//    class Vehicle
//    {
//        public virtual void Go()
//        {

//        }
//    }
//    class Car : Vehicle
//    {
//        public override void Go()
//        {
//            Console.WriteLine("The car is moving!");
//        }
//    }
//    class Bicycle : Vehicle
//    {
//        public override void Go()
//        {
//            Console.WriteLine("The bicycle is moving!");
//        }
//    }
//    class Boat : Vehicle
//    {
//        public override void Go()
//        {
//            Console.WriteLine("The boat is moving!");
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 43. interfaces

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // interface =  defines a "contract" that all the classes inheriting from should follow

//            //              An interface declares "what a class should have"
//            //              An inheriting class defines "how it should do it"

//            //              Benefit = security + multiple inheritance + "plug-and-play"

//            Rabbit rabbit = new Rabbit();
//            Hawk hawk = new Hawk();
//            Fish fish = new Fish();

//            rabbit.Flee();
//            hawk.Hunt();
//            fish.Flee();
//            fish.Hunt();

//            Console.ReadKey();
//        }
//        interface IPrey
//        {
//            void Flee();
//        }
//        interface IPredator
//        {
//            void Hunt();
//        }
//        class Rabbit : IPrey
//        {
//            public void Flee()
//            {
//                Console.WriteLine("The rabbit runs away!");
//            }
//        }
//        class Hawk : IPredator
//        {
//            public void Hunt()
//            {
//                Console.WriteLine("The hawk is searching for food!");
//            }
//        }
//        class Fish : IPrey, IPredator
//        {
//            public void Flee()
//            {
//                Console.WriteLine("The fish swims away!");
//            }
//            public void Hunt()
//            {
//                Console.WriteLine("The fish is searching for smaller fish");
//            }
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 44. Lists

//using System;
//using System.Collections.Generic;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // List =   data structure that represents a list of objects that can be accessed by index.
//            //          Similiar to array, but can dynamically increase/decrease in size
//            //          using System.Collections.Generic;

//            List<String> food = new List<String>();

//            //food.Add("fries");
//            food.Add("pizza");
//            food.Add("hamburger");
//            food.Add("hotdog");
//            food.Add("fries");

//            //food.Remove("fries");
//            //food.Insert(0, "sushi");
//            //Console.WriteLine(food.Count);
//            //Console.WriteLine(food.IndexOf("pizza"));
//            //Console.WriteLine(food.LastIndexOf("fries"));
//            //Console.WriteLine(food.Contains("pizza"));
//            //food.Sort();
//            //food.Reverse();
//            //food.Clear();
//            //String[] foodArray = food.ToArray();

//            foreach (String item in foodArray)
//            {
//                Console.WriteLine(item);
//            }

//            //Console.WriteLine(food[0]);

//            Console.ReadKey();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 45. List of objects

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            List<Player> players = new List<Player>();

//            players.Add(new Player("Chad"));
//            players.Add(new Player("Steve"));
//            players.Add(new Player("Karen"));

//            foreach (Player player in players)
//            {
//                Console.WriteLine(player);
//            }


//            Console.ReadKey();
//        }
//    }
//    class Player
//    {
//        public String username;
//        public Player(String username)
//        {
//            this.username = username;
//        }
//        public override string ToString()
//        {
//            return username;
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 46. getters & setters

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // getters & setters =  add security to fields by encapsulation
//            //                      They're accessors found within properties

//            // properties = combine aspects of both fields and methods (share name with a field)
//            // get accessor = used to return the property value
//            // set accessor = used to assign a new value
//            // value keyword = defines the value being assigned by the set (parameter)

//            Car car = new Car(400);

//            car.Speed = 1000000000;

//            Console.WriteLine(car.Speed);

//            Console.ReadKey();
//        }
//    }
//    class Car
//    {
//        private int speed;

//        public Car(int speed) 
//        {
//            Speed = speed;
//        }

//        public int Speed
//        {
//            get { return speed; }   // read
//            set                     // writeable
//            {
//                if (value > 500)
//                {
//                    speed = 500;
//                }
//                else
//                {
//                    speed = value;
//                }
//            }
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 47. auto implemented properties

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // Auto-Implemented properties =    shortcut when no additional logic is required in the property
//            //                                  you do not have to define a field for a property,
//            //                                  you only have to write get; and/or set; inside the property

//            Car car = new Car("Porsche");

//            Console.WriteLine(car.Model);

//            Console.ReadKey();
//        }
//    }
//    class Car
//    {

//        public string Model { get; set; }

//        public Car(String model)
//        {
//            this.Model = model;
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 48. enums

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // enums =  special "class" that contains a set of named integer constants.
//            //          Use enums when you have values that you know will not change,
//            //          To get the integer value from an item, you must explicity convert to an int

//            //          name = integer

//            //Console.WriteLine(Planets.Mercury + " is planet #" + (int)Planets.Mercury);
//            //Console.WriteLine(Planets.Pluto + " is planet #" + (int)Planets.Pluto);

//            String name = PlanetRadius.Earth.ToString();
//            int radius = (int)PlanetRadius.Earth;
//            double volume = Volume(PlanetRadius.Earth);

//            Console.WriteLine("planet: " + name);
//            Console.WriteLine("radius: " + radius + "km");
//            Console.WriteLine("volume: " + volume + "km^3");

//            Console.ReadKey();
//        }
//        public static double Volume(PlanetRadius radius)
//        {
//            double volume = 4.0 / 3.0 * Math.PI * Math.Pow((int)radius, 3);
//            return volume;
//        }
//    }
//    enum Planets
//    {
//        Mercury = 1,
//        Venus = 2,
//        Earth = 3,
//        Mars = 4,
//        Jupiter = 5,
//        Saturn = 6,
//        Uranus = 7,
//        Neptune = 8,
//        Pluto = 9
//    }
//    enum PlanetRadius
//    {
//        Mercury = 2439,
//        Venus = 6051,
//        Earth = 6371,
//        Mars = 3389,
//        Jupiter = 69911,
//        Saturn = 58232,
//        Uranus = 25362,
//        Neptune = 24622,
//        Pluto = 1188
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 49. generics

//using System;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // generic =    "not specific to particular data type"
//            //              add <T> to: classes, methods, fields, etc.
//            //              allows for code reusability for different data types

//            int[] intArray = { 1, 2, 3 };
//            double[] doubleArray = { 1.0, 2.0, 3.0 };
//            String[] stringArray = { "1", "2", "3" };

//            displayElements(intArray);
//            displayElements(doubleArray);
//            displayElements(stringArray);

//            Console.ReadKey();
//        }
//        public static void displayElements<Thing>(Thing[] array)
//        {
//            foreach (Thing item in array)
//            {
//                Console.Write(item + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------------------------

// 50. multithreading

//using System;
//using System.Threading;

//namespace Csharp_Codes_Meanings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

//            // thread = an execution path of a program
//            //          We can use multiple threads to perform,
//            //          different tasks of our program at the same time.
//            //          Current thread running is "main" thread
//            //          using System.Threading;

//            Thread mainThread = Thread.CurrentThread;
//            mainThread.Name = "Main Thread";
//            //Console.WriteLine(mainThread.Name);

//            Thread thread1 = new Thread(CountDown);
//            Thread thread2 = new Thread(CountUp);
//            thread1.Start();
//            thread2.Start();

//            Console.WriteLine(mainThread.Name + " is complete!");

//            Console.ReadKey();
//        }
//        public static void CountDown()
//        {
//            for (int i = 10; i >= 0; i--)
//            {
//                Console.WriteLine("Timer #1 : " + i + " seconds");
//                Thread.Sleep(1000);
//            }
//            Console.WriteLine("Timer #1 is complete!");
//        }
//        public static void CountUp()
//        {
//            for (int i = 0; i <= 10; i++)
//            {
//                Console.WriteLine("Timer #2 : " + i + " seconds");
//                Thread.Sleep(1000);
//            }
//            Console.WriteLine("Timer #2 is complete!");
//        }
//    }
//}