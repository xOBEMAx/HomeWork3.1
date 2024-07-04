using System;

public class Month
{
    public static void CheckMonthByNumber()

    {
        Console.Write("Введите номер месяца: ");
        var monthNumber = Convert.ToInt32(Console.ReadLine());

        switch (monthNumber)
        {
            case 1:
                Console.WriteLine("Январь");
                break;
            case 2:
                Console.WriteLine("Февраль");
                break;
            case 3:
                Console.WriteLine("Март");
                break;
            case 4:
                Console.WriteLine("Апрель");
                break;
            case 5:
                Console.WriteLine("Май");
                break;
            case 6:
                Console.WriteLine("Июнь");
                break;
            case 7:
                Console.WriteLine("Июль");
                break;
            case 8:
                Console.WriteLine("Август ");
                break;
            case 9:
                Console.WriteLine("Сентябрь");
                break;
            case 10:
                Console.WriteLine("Октябрь");
                break;
            case 11:
                Console.WriteLine("Ноябрь");
                break;
            case 12:
                Console.WriteLine("Декабрь");
                break;
            default:
                Console.WriteLine("Вы ввели неправильные данные! Попробуйте еще раз");
                break;
        }
    }
    public static void CheckTimeOfYear()
    {
        Console.Write("Введите номер месяца: ");
        var monthNumber = Convert.ToInt32(Console.ReadLine());

        if(monthNumber == 12 || monthNumber == 1 || monthNumber == 2)
        {
            Console.WriteLine("Пора года - зима");
        }
        else if (monthNumber == 3 || monthNumber == 4 || monthNumber == 5)

        {
            Console.WriteLine("Пора года - весна");
        }
        else if (monthNumber == 6 || monthNumber == 7 || monthNumber == 8)
        {
            Console.WriteLine("Пора года - Лето");
        }
        else if (monthNumber == 9 || monthNumber == 10 || monthNumber == 11)
        {
            Console.WriteLine("Пора года - Осень");
        }
        else
        {
            Console.WriteLine("Вы ввели неправильные данные! Попробуйте еще раз");
        }
    }
    public static void CheckMonthEven()
    {
        Console.Write("Введите номер месяца: ");
        var monthNumber = Convert.ToInt32(Console.ReadLine());

        if (monthNumber % 2 == 0)
        {
            Console.WriteLine("Число четное");
        }
        else
        {
            Console.WriteLine("Число не четное");
        }
    }
    
}
