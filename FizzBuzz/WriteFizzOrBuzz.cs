using System.Globalization;
using System.Configuration;

namespace FizzBuzz
{
    class WriteFizzOrBuzz
    {
        public static string GetMessageToWrite(int number)
        {
            
            var fizz = ConfigurationManager.AppSettings["Fizz"];
            var buzz = ConfigurationManager.AppSettings["Buzz"];

            if (CanDevide.By3(number) && CanDevide.By5(number))
            {
                return fizz + " " + buzz;
            }
            if (CanDevide.By3(number))
            {
                return fizz;
            }
            return CanDevide.By5(number) ? buzz : number.ToString(CultureInfo.CurrentCulture);
        }

        
    }
}
