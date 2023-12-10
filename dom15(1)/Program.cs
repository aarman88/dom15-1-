using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        // Получаем тип класса Console
        Type consoleType = typeof(Console);

        // Получаем массив методов класса Console
        MethodInfo[] methods = consoleType.GetMethods();

        // Выводим на экран список методов
        Console.WriteLine("Методы класса Console:");
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}
