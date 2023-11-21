using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicExceptionHandling();
            MultipleExceptionTypes();
            FinalyBlockUsage();
            CustomExceptionClass();
            ExceptionPropagation();
            UsingThrowAndCatch();
        }

        static void BasicExceptionHandling()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Convert the input to an integer using int.Parse().
            // Use a try-catch block to handle FormatException if the user enters a non-numeric value.
            // Display an error message in case of an exception.
            // Output the input if correct
            try
            {              
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("the number is " + num);
            }
            catch
            {
                Console.WriteLine("This is not a number");
            }
            finally
            {
                Console.WriteLine("Please enter another number");
            }
        }

        static void MultipleExceptionTypes()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Include a catch block for OverflowException to handle cases where the number is too large or small for an int.
            // Display appropriate error messages for different exceptions.
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("the number is " + num);
            }
            catch (OverflowException)
            {
                Console.WriteLine("the number is out of range for int32.");
            }
            finally
            {
                Console.WriteLine("Please enter another number");
            }

        }

        static void FinalyBlockUsage()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Add a finally block to the program.
            // Use the finally block to display a message whether an exception was caught or not.
            Boolean notnum = false;
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("the number is " + num);
            }
            catch
            {
                Console.WriteLine("This is not a number");
                notnum = true;
                
            }
            finally
            {
                
                if (notnum==false)
                {
                    Console.WriteLine("No error occured");
                }
                else
                {
                    Console.WriteLine("an exception occured");
                }
            }
        }

        // Class for custom exception type
        class NegativeNumberException : ApplicationException
        {
            public NegativeNumberException(string message) : base(message) { }
        }

        static void CustomExceptionClass()
        {
            Console.Write("Enter a number4: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Modify your number input program to throw NegativeNumberException if the user enters a negative number.
            // Handle this exception in a separate catch block and display an appropriate message.
            try
            {
                int num = int.Parse(Console.ReadLine());
                //
                if (num>0)
                {
                    Console.WriteLine("the number is " + num);
                }
                else
                {
                    throw new NegativeNumberException("Please enter a positive number");
                }    
            }
            catch (NegativeNumberException) 
            {
                Console.WriteLine("a negative number was entered");
            }
            finally
            {
                Console.WriteLine("Please enter another number");
            }
        }

        static void ExceptionPropagation()
        {
            Console.Write("Enter a number5: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Write a function CheckNumber that takes an integer and throws ArgumentOutOfRangeException if the number is greater than 100.
            // In this function, call CheckNumber inside a try block and handle the exception.

            try
            {
                int num = int.Parse(Console.ReadLine());
                CheckNumber(num);
                Console.WriteLine("the number is " + num);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Entered Number is above 100");
            }
            finally
            {
                Console.WriteLine("Please enter another number");
            }
        }

        // NOTE: You can implement the CheckNumber here
        static void CheckNumber(int numtocheck)
        {
            if (numtocheck > 100)
            {
                
                throw new ArgumentOutOfRangeException("Number is above 100");
                
            }
        }

        static void UsingThrowAndCatch()
        {
            Console.Write("Enter a number6: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Write a function CheckNumberWithLogging that takes an integer and throws ArgumentOutOfRangeException if the number is greater than 100.
            // Modify the CheckNumberWithLogging function to log the exception message before throwing it.
            // In this function, catch the exception in the main program and display the logged message.

            try
            {
                int num = int.Parse(Console.ReadLine());
                CheckNumberWithLogging(num);
                Console.WriteLine("the number is " + num);

            }
            catch (ArgumentOutOfRangeException ex) 
            {
                
                Console.WriteLine("Entered number is above 100");
                Console.WriteLine(ex.ToString());
                
            }
            finally
            {
                Console.WriteLine("Please enter another number");
            }
        }
        static void CheckNumberWithLogging(int numtocheck)
        {
            if (numtocheck > 100)
            {
                
                throw new ArgumentOutOfRangeException("Number is above 100");
                
            }
        }
    }

    // NOTE: You can implement the CheckNumberWithLogging here


}