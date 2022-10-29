// Первый вид методов - не принимает никаких аргументов и ничего не возвращают
/*
void Method1() // Вывести имя автора на экран
{
    Console.WriteLine("Автор: ooze");
}
Method1();
*/
// Второй вид методов:
/*
void Method2(string msg) // принимает строку которую надо вывести на экран
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
int Method3() // вывести текущий год на экран
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
*/
// Четвертый вид методов:
/*
string Method4(int count, string text) // принимает текст и колличество раз, возвращает готовую строку
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
string Method4(int count, string text) // принимает текст и колличество раз, возвращает готовую строку
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
/*
for(int i =2; i <= 10; i++)
{
    for(int j =2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
*/
// Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к» заменить большими «К», а большие «С» заменить на маленькие «с».

// string s = "qwerty"
//             012345
// s[3] - r
/*
string text = "Я думаю, - сказал Князь улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгороде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы.Вы дадите мне чаю?"; 
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; //инициализация пустой строки
    int length = text.Length; // свойство показывающее колличество символов в строке
   // for(int i = 0; i < length; i++)
    int i = 0;
    while(i < length)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
        i++;
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
*/

// Сортировка массива по возрастанию
/*
int [] arr = {1, 5, 4 , 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);
void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition = i;

        for(int j = i + 1; j < array.Length ; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
SelectionSort(arr);
PrintArray(arr);

// Сtrl+пробел - начинаете писать for - в списке выбрать for for loop
*/
// Сортировка массива по убыванию
int [] arr = {1, 5, 4 , 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);
void SelectionSortMax(int[] array)
{
    for(int i = 0; i < array.Length - 1 ; i++)
    {
        int maxPosition = i;

        for(int j = i + 1; j < array.Length ; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}
SelectionSortMax(arr);
PrintArray(arr);