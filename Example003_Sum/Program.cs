// int (integer) - контейнер,который позволяет работать 
// с целыми числами, например, ответом в задаче будет (8).

// Вариант 1:
// int numberA = 3;
// int numberB = 5;
// Console.WriteLine(numberA + numberB);

// Вариант 2. Можно сделать через промежуточную переменную (int result):
// int numberA = 33;
// int numberB = 5;
// int result = numberA + numberB;
// Console.WriteLine(result);

// 3. Вариант:
// Случайности:
// new Random().Next(min, max) 
// Даст случайное целое число: 
// от min до max-1 [min, max-1] или [min, max)

// Это значит, что я хочу новое случайное следующее число в диапазоне от min до max.
// (т.е. [min, max) выступает здесь таким ПОЛУИНТЕРВАЛОМ, в котором min у нас будет 
// включён в наш полуинтервал, а max число будет на единичку меньше.
// *Помним, что Next выдаёт случайное целое число.

int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
