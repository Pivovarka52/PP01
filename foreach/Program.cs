using System;
using System.Collections.Generic;

class Program_3_3
{
    static void Main()
    {
        Console.WriteLine("Пример 3.3: Цикл foreach");
        Console.WriteLine("------------------------");
        Console.WriteLine();
        
        // Фиксированный список товаров из магазина "Магнит"
        List<string> products = new List<string> 
        { 
            "Молоко", 
            "Хлеб", 
            "Яйца", 
            "Сахар", 
            "Масло" 
        };
        
        List<double> prices = new List<double> 
        { 
            89.90, 
            45.50, 
            120.00, 
            65.00, 
            150.00 
        };
        
        Console.WriteLine("Список покупок в магазине 'Магнит':");
        Console.WriteLine();
        
        double total = 0;
        int index = 0;
        
        // Цикл foreach для вывода всех товаров
        foreach (string product in products)
        {
            double price = prices[index];
            total += price;
            
            Console.WriteLine($"{product}: {price:F2} руб.");
            index++;
        }
        
        Console.WriteLine();
        Console.WriteLine("Общая сумма: {0:F2} руб.", total);
        Console.WriteLine();
        
        // Второй пример: только цены
        Console.WriteLine("Перебор только цен с помощью foreach:");
        Console.WriteLine("Цены товаров:");
        
        foreach (double price in prices)
        {
            Console.Write($"{price:F2} ");
        }
        
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Цикл foreach выполнил:");
        Console.WriteLine("1. Прошелся по всем товарам в списке");
        Console.WriteLine("2. Вывел название и цену каждого");
        Console.WriteLine("3. Подсчитал общую сумму покупки");
        
        Console.WriteLine();
        Console.Write("Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}