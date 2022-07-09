// 1. Пример. Классический стихийный подход:

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 33;

// int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;

// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;

// Console.WriteLine(max);


// 2.1. Пример. Теперь воспользуемся ФУНКЦИЯМИ:

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// // Сначала сделаем для: int max1 = Max(a1, b1, c1), поставив СЛЭШИ на остальные
// int a2 = 12;
// int b2 = 2311;
// int c2 = 33;
// // Затем сделаем для: int max2 = Max(a2, b2, c2), поставив СЛЭШИ на остальные.
// int a3 = 13;
// int b3 = 23;
// int c3 = 313;
// // Затем сделаем для: int max3 = Max(a3, b3, c3), поставив СЛЭШИ на остальные.

// int max1 = Max(a1, b1, c1);
// Console.WriteLine(max1);


// 2.2. Пример. Теперь воспользуемся ФУНКЦИЯМИ:
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 112125;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23111;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 313;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(max);

