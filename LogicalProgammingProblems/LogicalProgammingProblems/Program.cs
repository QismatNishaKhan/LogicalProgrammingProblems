using System.Globalization;

namespace LogicalProgammingProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select program \n1.Fibonacci series\n2 Given Number is Perfect or Not\n3.Enter the number to check either its Prime num or not\n4. Reverse Number\n5.Coupan Number\n6.Stopwatch Program\n7.Day Of The Week\n8.Temperatur Conversion");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries fibonacciSeries = new FibonacciSeries();
                        fibonacciSeries.FibonoccSeriesNumber();
                        break;
                    case 2:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.PerfectNum();
                        break;
                    case 3:
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.PrimeNumCheck();
                        break;
                    case 4:
                        ReverseNumber reverseNumber = new ReverseNumber();
                        reverseNumber.RevNumber();
                        break;
                    case 5:
                        CoupanNumber coupanNumber = new CoupanNumber();
                        coupanNumber.DistnictCoupanNumber();
                        break;
                    case 6:
                        StopwatchProgram stopwatchProgram = new StopwatchProgram();
                        stopwatchProgram.StopWatch();
                        break;
                    case 7:
                        GregorianCalendar gregorianCalendar = new GregorianCalendar();
                        gregorianCalendar.DayOfWeek();
                        break;
                    case 8:
                        TemperaturConversion temperaturConversion = new TemperaturConversion();
                        temperaturConversion.TempConversion();
                        break;
                }
            }
        }
    }
}