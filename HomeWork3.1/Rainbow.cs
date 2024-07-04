using System;



public class Rainbow
{
    public static void CheckRainbowColor()
    {

        Console.WriteLine("Введите номер цвета: " +
            "\n1 - Красный" +
            "\n2 - Зеленый" +
            "\n3 - Желтый" +
            "\n4 - Синий" +
            "\n5 - темно-зеленый" +
            "\n6 - темно-синий" +
            "\n7 - темно-красный");

        var color = Convert.ToInt32(Console.ReadLine());


        switch (color)
        {
            case 1:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Цвет красный");
                break;
            case 2:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Цвет зеленый");
                break;
            case 3:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Цвет желтый");
                break;
            case 4:
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Цвет синий");
                break;
            case 5:
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Цвет темно-зеленый");
                break;
            case 6:
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Цвет темно-синий");
                break;
            case 7:
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Цвет темно-красный");
                break;

            default:
                break;

                Console.ResetColor();
        }
    }
}

