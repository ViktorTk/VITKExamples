Console.Clear();

int [] array = {1, 12, 31, 4, 18, 15, 16, 17, 18};  //если есть индексы с одинаковыми значениями -> покажет все значения

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // если выставить брейк - будет показывать только первый искомый элемент (дальнейшие элементы не будет выводить)
    }
    //index = index + 1
    index++;
}