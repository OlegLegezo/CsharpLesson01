
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "эля")
{
    Console.WriteLine("привет, Элечка!!!");
}
else
{
    Console.Write ("Привет, ");
    Console.WriteLine (username);
}
