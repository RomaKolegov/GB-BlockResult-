/*
Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

int GetArrayLengthFromUser(string message)
{
    Console.WriteLine(message);
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

string[] GenerateArrayFromUser(int length)
{
    string [] array = new string [length];
    int count = 1;
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите значение для элемента массива {count++}");
        array[i] = Console.ReadLine();
        if (array[i] == string.Empty)
            {
                array[i] = "-";
            }
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

int NumberOfValuesUpToThreeCharacters(string[] array)
{
    int maxLengthCharacters = 3;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLengthCharacters)
        {
            count++;
        }
    }
    return count;
}

