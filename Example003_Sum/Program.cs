// Нахождение суммы заданных чисел из типа данных int

// int numberA = 3;
// int numberB = 5;
// int result = numberA + numberB;
// Console.WriteLine(result);

// Нахождение суммы случайных чисел
// Random(); - генератор случайных чисел, Next(min, max) - целоечисло из диапазона min - max-1;

int numberA = new Random().Next(1, 10); // 1, 2, 3, 4, 5 .... 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);

