// Задача:
// 1. Определить три точки.
// 2. Выбрать две любые.
// 3. Найти середину.
// 4. Поставть точку.
// 5. Выбрать случайную середину треугольника.
// 6. Соединить её сполученной на четвертом шаге точкой.
// 7. Перейти к шагу 3.
// 8. Шаги 3-7 повторять N-ое к-во раз.

Console.Clear();
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+");

int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.Write("+");

Console.SetCursorPosition(xb, yb);
Console.Write("+");

Console.SetCursorPosition(xc, yc);
Console.Write("+");

int x = xa, y = ya;

int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 3); // [0; 3) полуинтервал, выводит 0, 1, 2.
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }


    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}