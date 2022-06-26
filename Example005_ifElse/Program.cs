﻿// string - это обозначение типа данных - строка, username - заданное нами имя переменной.
// if(username == "маша")
// При такой записи имени пользователя с большой буквы, для его иднтификации возможны сложности
// из-за того, что пользователь может вводить своё иимя без учета регистра
// Во избежания такой сложности, лучше писать например: username.ToLower()
// и имя ожидаемого пользователя с маленькой буквы, в нашем случае: "маша".
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "маша") 
{
    Console.WriteLine("УРА!!! ЭТО ЖЕ МАША!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username + "!");
}
