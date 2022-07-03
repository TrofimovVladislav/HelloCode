// Типы Методов
//---------------------------------------------------------------------
// Тип 1: Метод никаких аргументов не принимает и ничего не возвращает
// Т.е. Этот метод что-то выполняет (в данном случае тело метода не описано)
// и может в конце его исполнения вывести, например, "Имя Автора".

void Method1()
{
    Console.WriteLine("Имя Автора");
}

// Method1(); // Команда на вывод метода
// ----------------------------------------------------------------------------
// Тип 2: Метод может принимать какаие-то аргументы, но ничего не возвращают.

void Method2(string msg)  // string - ТипДанных (в данном случае - строка(string)), msg - Аргумент. 
{
    Console.WriteLine(msg);
}

// Method2("Текст сообщения");   

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine("Текст");
        i++;
    }
}
//  Method21(msg: "Текст", count: 4); 

/* Именованные ргументы, т.е. указываемое, значение "Текст" 
- это значение присваивается конкретно аргументу msg,
а значение 4 конкретно аргументу - count.
При использовании именованных аргументов, при вызове функции,
можно писать в любом порядке, т.е. отличном при задании ф-ции. */

// Method21(count: 4, msg: "Новый текст");   

// ----------------------------------------------------------------------
// Тип 3: Метод ничего не принмает, но что-то возвращает
/* Если метод что-то возвращает, обязательно указываем тип данных
которые он возвращает */

int Method3()
{
    return DateTime.Now.Year;  // Это тело метода
}

// int year = Method3();   // Объявляем переменную в которую будет возвращен результат работы метода.
// Console.WriteLine(year);  // Выводим значение переменной на экран.

// -------------------------------------------------------------------------------------
// Метод 4: Метод что-то принимает и что-то возвращает

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

// string res = Method4(10, "Строка");
// Console.WriteLine(res);

/* string res - вводим переменную res, тип данных строка (string) 
для записи в неё результата вычисления нашего метода Method4. */

// --------------------------------------------------------------------
// Циклы. Цикл for.
/* Принципиальный вид цикла for:
for(int i = 0; i < 10; i++)
{
    Console.WriteLine(i)
}
*/

// Метод 4 с использованием цикла for (вместо цикла while) 

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

// string res = Method4(10, "Строка");
// Console.WriteLine(res);

// Цикл в цикле.

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 1; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// Задача на применеие цикла for
/* Дан текст, в котором все пробелы нужно заменить на |, все маленикие буквы к нужно 
заменить на большие буаквы К, а все большие буквы С - заменить на маленькие буквы с.
*/

string text = "— Я думаю, — сказал князь, улыбаясь,"
            + "— что, ежели бы ваС послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. Вы так красноречивы."
            + "Вы дадите мне чаю?";


// string s = "qwerty'
//             012345 - Поясняем, что в строке первыйсимвол - 0, второй - 1 и т.д
// s[3] - это третий символ, в нашем случае это - r.

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

// // string newText = Replace(text, ' ', '|');

// // newText = Replace(newText, 'к', 'К');
// // newText = Replace(newText, 'С', 'с');
// // Console.WriteLine(newText);

// // Задача на упорядочивание массива

int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(array);
SelectionSort(array);

PrintArray(array);

