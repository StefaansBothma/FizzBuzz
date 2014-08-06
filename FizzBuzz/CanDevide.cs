namespace FizzBuzz
{
    class CanDevide
    {
        public static bool By3(int number)
        {
            return number > 0 && number % 3 == 0;
        }

        public static bool By5(int number)
        {
            return number > 0 && number % 5 == 0;
        }
    }
}
