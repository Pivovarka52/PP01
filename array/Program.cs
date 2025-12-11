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