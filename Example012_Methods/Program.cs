// Вид 1

void Methods()
{
    Console.WriteLine("Автор ....");
}
Methods();

// Вид 2

void Methods(string msg)
{
    Console.WriteLine(msg);
}
Methods("Текст сообщения");

void Methods2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Methods2(msg: "Текст сообщения", count: 4);

// Вид 3

int Methods3()
{
    return DateTime.Now.Year;
}
int year = Methods();
Console.WriteLine(year);

// Вид 4

string Methods(int count, string c)
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
        }
    return result;
}
string res = Methods(10, "asdf");
Console.WriteLine(res);




string Methods(int count, string c)
{
    string result = string.Empty;
    for (i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Methods(10, "asdf");
Console.WriteLine(res);





for (int i = 2; i <= 10; i++)
{
    for (int j = 2; i <= 10; i++)
    {
        Console.WriteLine($"(i) x (j) =(i * j)");
    }
    Console.WriteLine();
}




// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого"
            + "Винценгероде, вы бы взяли приступом согласие"
            + "прусского короля. Вы так красноречивы. Вы"
            + "дадите мне чаю?";

// string s = "qwerty";
//             012345;
// s[3]           r

string Replace(string text, char oldvalue, char newvalue)
{
    string result = string.Empty;

    int lenght = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text(i) == oldvalue) result = result + $"{newvalue}";
        else result = result + $"{text(i)}";
    }


    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = 1;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}
SelectionSort(array);
PrintArray(arr);