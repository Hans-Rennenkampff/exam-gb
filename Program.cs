using System;

class Program
{
    static void Main()
    {
        // Введите или создайте массив строк
        Console.WriteLine("Введите элементы массива через запятую:");
        string[] inputArray = Console.ReadLine().Split(',');

        // Формирование нового массива
        string[] newArray = FilterStrings(inputArray);

        // Вывод результата
        Console.WriteLine("Новый массив:");
        foreach (string item in newArray)
        {
            Console.WriteLine(item);
        }
    }

    static string[] FilterStrings(string[] inputArray)
    {
        int newSize = 0;

        // Подсчёт количества строк, удовлетворяющих условию
        foreach (string item in inputArray)
        {
            if (item.Length <= 3)
            {
                newSize++;
            }
        }

        // Создание нового массива
        string[] newArray = new string[newSize];
        int index = 0;

        // Заполнение нового массива
        foreach (string item in inputArray)
        {
            if (item.Length <= 3)
            {
                newArray[index] = item;
                index++;
            }
        }

        return newArray;
    }
}
