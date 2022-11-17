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
    for(int i =0; i<collection.Length; i++)
    {
        Console.WriteLine("Введите значение строки: ");
        collection[i]= Convert.ToString(Console.ReadLine());
    }
}

void PrintArray(string[] col)
{
    for (int position = 0; position < col.Length; position++)
    {
        Console.Write($"[{col[position]}] ");
    }
}

void PrintNewArray(string[] collection)
{
    int a =0;
    string[] newarray = collection;
    for(int i =0; i<collection.Length; i++)
    {
        if(collection[i].Length<=3)
        {
            newarray[a]= collection[i];
            Console.Write($"[{newarray[a]}] ");
            a++;
        }
    }
}

string[] array = new string [Size()];
FillArray(array);
PrintArray(array);
Console.WriteLine();
PrintNewArray(array);