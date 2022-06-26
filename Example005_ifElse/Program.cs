Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine(); // string - это обозначение типа данных, username - заданнон нами имя переменной

if(username == "Маша")
{
    Console.WriteLine("УРА!!! ЭТО ЖЕ МАША!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
