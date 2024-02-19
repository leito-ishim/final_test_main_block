// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] array = ["Hello", "2", "world", ":-)"];
string[] array1 = ["1234", "1567", "-2", "computer science"];
string[] array2 = ["Russia", "Denmark", "Kazan"];

//Функция подсчета элементов в массиве, удовлетворяющих условию: длина <=3
int NumElementsSatisfyingCondition(string[] arr)
{
    int rez = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) rez++;
    }

    return rez;
}

//Функция формирования массива строк, длина которых <=3
string[] ArrayStringsLessThanFourLong(string[] arr, int num)
{
    string[] result = new string[num];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            result[count] = arr[i];
            count++;
        }
    }

    return result;
}

//Функция для вывода массива строк в консоль
void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    if (i < arr.Length - 1) {
        Console.Write($"\"{arr[i]}\", ");
    }
    else {
        Console.Write($"\"{arr[arr.Length - 1]}\"");
    }
    Console.Write("]");
   
}

string[] rezult_array = ArrayStringsLessThanFourLong(array, NumElementsSatisfyingCondition(array));


PrintArray(array);
Console.Write(" \u2192 ");
PrintArray(rezult_array);
Console.WriteLine();

PrintArray(array1);
Console.Write(" \u2192 ");
PrintArray(ArrayStringsLessThanFourLong(array1, NumElementsSatisfyingCondition(array1)));
Console.WriteLine();

PrintArray(array2);
Console.Write(" \u2192 ");
PrintArray(ArrayStringsLessThanFourLong(array2, NumElementsSatisfyingCondition(array2)));


// Console.WriteLine(NumElementsSatisfyingCondition(array));

