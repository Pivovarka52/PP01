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