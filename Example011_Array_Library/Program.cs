void FillArray(int[] collection) // Метод заполнения массива
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // Метод печати массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // Метод поиска индекса заданного элемента массива
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    // int position = -1; По договоренности, в случае, если, 
    // не найдено искомое значение, то будет выводится -1
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
// array[6] = 9;
// array[7] = 9;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 9);
Console.WriteLine(pos);
