Console.Write("Введите имя пользователя");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Слава Маше!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}