// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();

int Size()
{
    Console.WriteLine("Введите длину масива в виде положительного числа: ");
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

void FillArray(string[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.WriteLine("Введите значение строки: ");
        collection[i] = Convert.ToString(Console.ReadLine());
    }
}

void PrintArray(string[] col)
{
    for (int position = 0; position < col.Length; position++)
    {
        Console.Write($"[{col[position]}] ");
    }
}

int EvenCount(string[] array)
{
    int result = 0;
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= 3) result++;
    }
    return result;
}

string[] Solution(string[] input, int count)
{
    string[] output = new string[count];

    int index = 0;
    int length = input.Length;

    for (int i = 0; i < length; i++)
    {
        if (input[i].Length <= 3)
        {
            output[index] = input[i];
            index++;
        }
    }
    return output;
}

string[] array = new string[Size()];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int evens = EvenCount(array);
string[] newArray = Solution(array, evens);
PrintArray(newArray);