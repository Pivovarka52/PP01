## Отчёт по ПП.01 «Разработка модулей программного обеспечения компьютерных систем».
# Выполнена Студентом Мельниковым Егором.
# Код array.cs
```C#
using System;

class Program_3_5
{
    static void Main()
    {
        Console.WriteLine("Пример 3.5: Работа с массивами");
        Console.WriteLine("-----------------------------");
        
        // Создаем массив кодов товаров
        string[] productCodes = { "4601", "4602", "4603", "4604", "4605" };
        string[] productNames = { "Молоко", "Хлеб", "Яйца", "Сахар", "Масло" };
        
        Console.WriteLine("\nСписок товаров в магазине:");
        for (int i = 0; i < productCodes.Length; i++)
        {
            Console.WriteLine($"{productCodes[i]} - {productNames[i]}");
        }
        
        Console.Write("\nВведите код товара для поиска: ");
        string searchCode = Console.ReadLine();
        
        // Поиск в массиве
        bool found = false;
        for (int i = 0; i < productCodes.Length; i++)
        {
            if (productCodes[i] == searchCode)
            {
                Console.WriteLine($"\nТовар найден!");
                Console.WriteLine($"Код: {productCodes[i]}");
                Console.WriteLine($"Название: {productNames[i]}");
                found = true;
                break;
            }
        }
        
        if (!found)
        {
            Console.WriteLine($"\nТовар с кодом '{searchCode}' не найден");
        }
        
        Console.Write("\nНажмите Enter для выхода...");
        Console.ReadLine();
    }
}
```

# Код FOREACH.cs
```C#
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
```

# Код Operator.cs
```C#
using System;

class Program_3_2
{
    static void Main()
    {
        Console.WriteLine("=== 3.2. УСЛОВНЫЙ ОПЕРАТОР ===");
        Console.WriteLine("Проверка акционного товара");
        Console.WriteLine();
        
        // Ввод данных
        Console.Write("Товар участвует в акции? (1-да, 0-нет): ");
        string answer = Console.ReadLine();
        bool isPromo = answer == "1" || answer.ToLower() == "да";
        
        Console.Write("Введите размер скидки (например: 15 для 15%): ");
        string discountInput = Console.ReadLine();
        
        // Преобразуем ввод: если пользователь ввел 15, значит 0.15
        decimal discount = 0;
        if (decimal.TryParse(discountInput, out decimal inputValue))
        {
            // Если ввели число типа 15 (проценты), делим на 100
            if (inputValue > 1)
                discount = inputValue / 100;
            else
                discount = inputValue;
        }
        
        Console.WriteLine();
        Console.WriteLine("Результат проверки:");
        Console.WriteLine($"Акционный товар: {(isPromo ? "ДА" : "НЕТ")}");
        Console.WriteLine($"Размер скидки: {discount * 100}%");
        
        // Проверка условия
        if (isPromo && discount > 0.10m)
        {
            Console.WriteLine("Применена повышенная скидка (более 10%)");
        }
        else if (isPromo)
        {
            Console.WriteLine("Применена обычная акционная скидка");
        }
        else
        {
            Console.WriteLine("Товар не акционный");
        }
        
        Console.WriteLine();
        Console.Write("Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}
```

# Код Stack.cs
```C#
using System;
using System.Collections.Generic;

class Program_3_6
{
    static void Main()
    {
        Console.WriteLine("Пример 3.6: Работа со стеком (Stack)");
        
        // Создаем стек
        Stack<string> operations = new Stack<string>();
        
        // Добавляем операции
        operations.Push("Продажа молока");
        operations.Push("Продажа хлеба");
        operations.Push("Отмена покупки");
        
        Console.WriteLine("\nВсе операции в стеке:");
        
        // Извлекаем операции (LIFO)
        while (operations.Count > 0)
        {
            string operation = operations.Pop();
            Console.WriteLine($"Извлечено: {operation}");
        }
        
        Console.ReadLine();
    }
}
```

# Код switch.cs
```C#
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
```

<img src="..\img\1.png" 
<img src="..\img\2.png" 
<img src="..\img\3.png" 
<img src="..\img\4.png" 
<img src="..\img\5.png" 
<img src="..\img\6.png" 


