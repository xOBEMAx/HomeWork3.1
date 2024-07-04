using System;

public class Temp
{
    public static void CheckWeather()
    {

        Console.Write("Введите температуру: ");
        var temp = Convert.ToInt32(Console.ReadLine());

        if (temp <= -20)
        {
            Console.WriteLine("Холодная погода");
        }
        else if (temp > -20 || temp < -5)
        {
            Console.WriteLine("Нормальная погода");
        }
        else if (temp >= -5)
        {
            Console.WriteLine(" Тепло ");
        }
        else
        {
            Console.WriteLine("Вы ввели неправильные данные! Попробуйте еще раз");
        }

    }
}
