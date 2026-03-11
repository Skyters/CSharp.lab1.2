namespace lab1._2
{
        public class Logic()
        {
            public static string CalculatingTheContribution(double sum, double result1, double result2)
            {
                double newSum = sum;
                double percent; // %
                bool flagRes1 = false;
                bool flagRes2 = false;

                string result = "";

                int month = 20;

                for (int i = 1; i < month + 1; i++)
                {
                    percent = newSum * 0.02;
                    newSum = newSum + percent;

                    if (percent > result1 && !flagRes1)
                    {
                        result += "\nНа " + i + " месяце было превышение";
                        flagRes1 = true;
                    }

                    if (newSum > result2 && !flagRes2)
                    {

                        result += "\nЧерез " + i + " месяцев мы накопим деньги";
                        flagRes2 = true;
                    }

                    result += "\nМесяц " + i + ": " + newSum.ToString("F2") + " руб. " + " " + percent.ToString("F2");
                }

                return result;
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                double sum;
                double result1;
                double result2;

                Console.Write("Введите первоначальный взнос: ");
                string strSum = Console.ReadLine();
                Console.Write("Укажите границу превышения величины ежемесячного увеличения вклада: ");
                string strRes1 = Console.ReadLine();
                Console.Write("Укажите границу превышения размера вклада за n-месяцев: ");
                string strRes2 = Console.ReadLine();

                sum = Convert.ToDouble(strSum);
                result1 = Convert.ToDouble(strRes1);
                result2 = Convert.ToDouble(strRes2);

                if (sum < 0 || result1 < 0 || result2 < 0)
                {
                    Console.WriteLine("Значения должны быть положительны");
                    return;
                }
                else
                {
                    var res = Logic.CalculatingTheContribution(sum, result1, result2);
                    Console.WriteLine(res);
                }
            }
        }
}