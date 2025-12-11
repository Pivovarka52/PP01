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