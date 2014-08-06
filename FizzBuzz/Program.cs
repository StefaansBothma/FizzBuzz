using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter number to check: ");
                var value = Console.ReadLine();

                if (IsValidNumber(value) && value != null)
                {
                    var number = int.Parse(value);

                    for (var i = 0; i <= number; i++)
                    {
                        Console.WriteLine(WriteFizzOrBuzz.GetMessageToWrite(i));
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number was entered");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An Error has occured: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Press any key to close...");
                Console.ReadKey();
            }
        }

        private static bool IsValidNumber(string enteredNumber)
        {
            int number;
            return int.TryParse(enteredNumber, out number);
        }
    }
}
