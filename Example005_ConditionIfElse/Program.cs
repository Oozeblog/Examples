Console.Write("Введите имя пользователя ");
var username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура! Это же Маша!");
}
else
{
    Console.Write("Привет, ");
}
Console.Write(username);