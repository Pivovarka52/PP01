using System;

class program
{
    static void Main()
    {
        Console.Write("Введите код магазина (A/B/C): ");
        string code = Console.ReadLine().ToUpper();
        
        switch(code)
        {
            case "A":
                Console.WriteLine("Тип: Гипермаркет");
                break;
            case "B":
                Console.WriteLine("Тип: Супермаркет");
                break;
            case "C":
                Console.WriteLine("Тип: Магазин у дома");
                break;
            default:
                Console.WriteLine("Неизвестный код");
                break;
        }
        
        Console.Write("Выход - Enter");
        Console.ReadLine();
    }
}