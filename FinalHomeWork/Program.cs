// Задача: Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 
// символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполненеия алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] a = new string[] { "hello", "2", "world", ":-)" };
string[] b = new string[] { "1234", "1567", "-2", "computer science" };
string[] c = new string[] { "Russia", "Denmark", "Kazan" };

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

string[] StringLengthLessFour(string[] arr)
{
    int newArrLength = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int count = 0;
        for (int j = 0; j < arr[i].Length; j++)
        {
            count++;
        }
        if (count < 4)
        {
            newArrLength++;
        }
    }

    string[] newArr = new string[newArrLength];
    int newArrIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int count = 0;
        for (int j = 0; j < arr[i].Length; j++)
        {
            count++;
        }
        if (count < 4)
        {
            newArr[newArrIndex] = arr[i];
            newArrIndex++;
        }
    }
    return newArr;
}

PrintArray(StringLengthLessFour(a));
PrintArray(StringLengthLessFour(b));
PrintArray(StringLengthLessFour(c));

