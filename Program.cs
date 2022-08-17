namespace Урок3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double first;
            double second;
           
            first = GetNum("первое");
            second = GetNum("второе");
            GetAnswer(first, second);
            Console.ReadKey();
        }
        static void GetAnswer(double fir, double sec)
        {
            if (fir > sec)
            {
                Console.WriteLine("Первое число больше второго.");
                return;
            }
            if (sec > fir)
            {
                Console.WriteLine("Второе число больше первого.");
                return;
            }
            Console.WriteLine("Числа равны");
        }
        static double GetNum(string str)
        {
            while (true)
            {
                Console.Write("Введите {0} число: ", str);
                if (double.TryParse(Console.ReadLine(), out double number))
                {
                    return number;
                    break;
                }
                Console.WriteLine("Внимание, введено не число!");
            }
        }
    }
}