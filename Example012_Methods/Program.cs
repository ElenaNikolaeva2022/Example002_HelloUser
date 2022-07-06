// ВИД 1. Первая группа методов - это методы,
// которые ничего не возвращают и ничего не принимают.
// Ониочень простые и выглядят следующим образом:

// void Method1()
// {
//     Console.WriteLine("Автор Елена Николаева");
// }
// Method1();

// Пунктик, который может быть интересен или нужен - это 
// как вызываются подобного рода методы.
// А вызываются они очень просто: Method1();




// ВИД 2. Вторая группа методов - это методы, которые ничего 
// не возвращают, но в тоже время могут принимать какие-то аргументы:

// Допустим, (void - ключевое слово) (Method2 - идентификатор) 
// и (string msg - какое-то количество аргументов):

// void Method2_0(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2_0("Текст сообщения");


// void Method2_1(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method2_1("Текст", 4);


// Мы можем явно указывать к какому аргументу какое значение 
// мы хотим присвоить через вот такую конструкцию(смотри 52 строку):
// void Method2_1a(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // Method2_1a(msg: "Текст", count: 4); - можно так или как показано ниже.
// Method2_1a(count: 4, msg: "новый текст");




// ВИД 3. Третья группа методов - это методы, которые что-то
// возвращают, но ничего не принимают:

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);





// ВИД 4. Четвёртая группа методов (самя важная) - это методы,  
// которые, что-то принимают и, что-то возвращают:
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text; 
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);


// Цыклы и нетолько while. Есть ещё ЦИКЛ "for" - он
// наиболее часто используется в разработке.
// Это ЦИКЛ со СЧЁТЧИКОМ и его называют "for".
// Синтаксически он просто в себе собирает всё в кучу.

// for(int i = 0;i < 10; i++)
// {
//     Console.WriteLine(i);
// }
// Синтаксис ЦИКЛА "for" примерно следующий:

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);

// Цыклы и нетолько while. Есть ещё ЦИКЛ "for" ЦИКЛ в ЦИКЛЕ.
// for(int i = 0; i < 10; i++)
// {
//    for(int j = 0; j < 10; j++)
//    {
//        Console.WriteLine(i*j)
//    }
// Console.WriteLine(i*j)
//}
// Например, задача выложить таблицу умножения на экран:

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 0; j <= 10; j++)
//     {
//         // Интерполяция строк - В компьютерном программировании интерполяция
//         // строк (или интерполяция переменных, подстановка переменных или 
//         //расширение переменных) - это процесс оценки строкового литерала,
//         //содержащего один или несколько заполнителей, в результате чего 
//         // заполнители заменяются соответствующими значениями.
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// ===== РАБОТА С ТЕКСТОМ
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясно ли задача?

string text = "_ Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
// индексы:    012345
// s[индекс, например 3], т.е. буква "r"

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'k', 'K');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'C', 'c');
// Console.WriteLine(newText);


// МАССИВЫ. упорядочиание данных внутри МАССИВА.
// Алгоритм сортировки методом выбора, его называют по-разному:
// Алгоритм сортировки методом МИНИМАКСА,
// или просто называют методом МАКСИМАЛЬНОГО,
// или выбором МАКСИМАЛЬНОГО, или выбором МИНИМАЛЬНОГО и т.д. 
// Давайте узнаем, в чём суть этого Алгоритма?

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
// Первый способ, пусть он называется "PrintArray"
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Пишем МЕТОД, который будет упорядочивать наш МАССИВ.
// Давайте назовём его "SelectionSort".
// В качестве аргумента будет приходить, некий МАССИВ "(int[]array)".
//:
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minPosition]) minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);