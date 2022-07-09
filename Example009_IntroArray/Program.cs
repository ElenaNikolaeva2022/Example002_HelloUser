// // ПИМЕР 1.
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// //              0     1   2   3   4   5   6   7   8
// int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 };
// array[0] = 12;
// Console.WriteLine(array[0]);    

// // И ожидаем на экране получить 12 
// // И ВИДИМ: 12


// // ПИМЕР 2.
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// // //            0    1   2   3   4   5   6   7   8
// int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 };
// array[0] = 12;
// Console.WriteLine(array[4]); 

// // вместо [0] поставили [4]
// // И ожидаем на экране получить 15 
// // И ВИДИМ: 15


// ПИМЕР 3.
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//              0     1   2   3   4   5   6   7   8
int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 };

// int max = Max(если смущает max с маленькой буквы, можно поставить result)
int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(result);