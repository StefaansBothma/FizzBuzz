namespace FizzBuzz
{
    class CanDevide
    {
        public static bool By3(int number)
        {
            return number > 2 && number % 3 == 0;
        }

        public static bool By5(int number)
        {
            return number > 4 && number % 5 == 0;
        }
    }
}
