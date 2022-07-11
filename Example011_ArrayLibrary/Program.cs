void FillArray(int[] collection) // 1. ПЕРВЫЙ МЕТОД
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        // index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)

{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);

// int [] array = Звучит это так:
// Начнём с того, что определим новый МАССИВ
// название, которому дадим array.

// new int[10]; Звучит это так: 
// Создай новый массив, в котором будет, например, 10 элементов.
// Есть методы, которые возвращают какие-то значения, а
// void (войт метод) - это метод, который ничего не возвращает.
// В коде мы тогда не должны будем использовать оператор return,
// который был, например, для поиска максимума из трёх.
// col, коротко от слова collection