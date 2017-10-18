using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           string date = "2017-02-02 16:26:43";
           DateTime dt= Convert.ToDateTime(date);
           long epoch= ConvertToEpoch(dt);
        }

        public static long ConvertToEpoch(DateTime date)
        {
            return (date.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
        }

    }
}
