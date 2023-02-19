Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "эля")
{
    Console.WriteLine("Ура! Это же ЭЛЯ!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}