Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if (username.ToLower() == "наташа")
{
    Console.WriteLine("Урa, это же Наташа!");
}
else 
{Console.WriteLine("Привет, ");
Console.WriteLine(username);
}