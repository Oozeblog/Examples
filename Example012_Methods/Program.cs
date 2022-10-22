// Первый вид методов:
/*
void Method1()
{
    Console.WriteLine("Автор: ooze");
}
Method1();
*/
// Второй вид методов:
/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Вызываем второй метод");
*/
/*
void Method21(string msg, int count)
{
    int i = 0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++; // ++ инкримент, -- декримент
    }
}
Method21(count: 4, msg: "Текст, 4 раза"); // именованные аргументы не обязательно использовать по порядку
// Ctrl + C - если завис терминал
*/
// Третий вид методов:
/*
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
*/
// Четвертый вид методов:
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    
    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);
*/
// Цикл for
/*
string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);
*/

//Цикл в цикле. Вывод таблицы умножения на экран
for(int i =2; i <= 10; i++)
{
    for(int j =2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}