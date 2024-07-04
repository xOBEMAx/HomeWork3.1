internal class Program
{
    private static void Main(string[] args)
    {
        bool isChecked = true;
        while (isChecked)
        {


            Console.WriteLine("Выберите действие: " +
                "\n1 - Узнать цвет Радуги по номеру цвета" +
                "\n2 - Узнать месяц по его номеру" +
                "\n3 - Узнать четность месяца" +
                "\n4 - Узнать время года" +
                "\n5 - Узнать погоду" +
                "\n6 - Выйти из программы");
            Console.Write("Ваш выбор: ");

            var opetation = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (opetation)
            {
                case 1:
                    Rainbow.CheckRainbowColor();
                    Console.ResetColor();
                    break;
                case 2:
                    Month.CheckMonthByNumber();
                    break;
                case 3:
                    Month.CheckMonthEven();
                    break;
                case 4:
                    Month.CheckTimeOfYear();
                    break;
                case 5:
                    Temp.CheckWeather();
                    break;
                case 6:
                    isChecked = false;
                    Console.WriteLine("До свидания!");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный выбор!");
                    break;
                    Console.ResetColor();

            }
            
            Console.ReadKey();
        }

    }
}