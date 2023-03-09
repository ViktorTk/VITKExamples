// Вид 1
//void Method1 () // ничего не возвращают, ничего не принимают
//{
//    System.Console.WriteLine("Автор ...."); // указать что-либо в конце программы, пример - автороство.
//}
//Method1 (); // Вызвать данный метод - просто указать его название, пример - Method1



// Вид 2
//void Method2 (string msg) // ничего не возвращают, но могут принимать какие-либо элементы
//{
//    Console.WriteLine(msg);
//}
//Method2 (msg: "Текст сообщения"); // нужно указывать аргумент, если их несколько, пример далее

/*void Method21 (string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}*/
//Method21 (msg: "Текст", count: 4); // для каждого аргумента значения указываем в одних скобках через запятую; При именовании переменных в скобках можно не соблюдать порядок, коунт на 1 место, мсг на 2 и т.д.
// ДЛЯ ВЫХОДА ИЗ ЗАЦИКЛЕННОЙ ПРОГРАММЫ ИСПОЛЬЗОВАТЬ СОЧЕТАНИЕ "Ctrl + C"



// Вид 3
/*int Method3 () // что-либо возвращают, ничего не принимают, у такого метода необходимо указывать тип данных, пример - int
{
    return DateTime.Now.Year;
}*/
//int year = Method3 ();
//Console.WriteLine (year);



// Вид 4
//string Method4 (int count, string c) // что-либо принимают и что-либо возвращают, также у такого метода необходимо указывать тип данных, пример - string
/*{
    int i = 0;
    string result = String.Empty; //"результ будет пустой строкой"
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;

}

string res = Method4 (10, "z");
Console.WriteLine (res); */

/*string Method4 (int count, string text) // тот же метод, но вместо "while"  -  "for"
{
    
    string result = String.Empty; //"результ будет пустой строкой"
    for ( int i = 0; i < count; i++ )
    {
        result = result + text;
    }
    return result;

}

string res = Method4 (10, "z");
Console.WriteLine (res);  */



// Цикл в цикле, на примере таблицы умножения
/*for ( int i = 2; i <= 10; i++ )
{
    for ( int j = 2; j <= 10; j++ )
    {
        Console.WriteLine ($"{i} x {j} = {i * j}");
    }
    Console.WriteLine ();
}*/



// === РАБОТА С ТЕКСТОМ
// Дан текст, в котором все пробелы нужно заменить на "|"
// Маленькие "к" заменить на большие "К"
// а большые "С" заменить на маленькие "с"

/*string text = "- Я думаю, - сказал князь, улыбаясь - что, "
            + "ежели бы вас послали вместо нашего милого Винценгеродеб"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s [3] // r

string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace (text, ' ', '|');

Console.WriteLine (newText);
Console.WriteLine ();
newText = Replace (newText, 'к', 'К');
Console.WriteLine (newText);*/



// ОТСОРТИРОВЫВАНИЕ МАССИВА (от минимума к максимуму)

int [] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray (int [] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write ($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort (int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}


/*void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}*/

PrintArray (arr);
SelectionSort (arr);

PrintArray (arr);