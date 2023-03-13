Console.Clear();

/*string[,] table = new string[2, 5]; // создаем матрицу, 2 строчки, 5 столбцов // начинается с 0 индекса, пример таблицы ниже
// table [0, 0]     table [0, 1]    table [0, 2]    table [0, 3]    table [0, 4]
// table [1, 0]     table [1, 1]    table [1, 2]    table [1, 3]    table [1, 4]

table[1, 2] = "слово"; // для обращения к нужному элементу нужно указать

for(int rows = 1; rows < 2; rows++)
{
    for(int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}*/



/*int[,] matrix = new int[3, 4];

for(int i = 0; i < 3; i++) // отчет по строкам
{
    for(int j = 0; j < 4; j++) // отчет по столбцам
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}*/






/*int[,] matrix = new int[3, 4];

void PrintArray(int[,] matr )
{
    for(int i = 0; i < matr.GetLength(0); i++) // отчет по строкам, правильно вместо "3" указывать "matrix.GetLength(0)"
    {
        for(int j = 0; j < matr.GetLength(1); j++) // отчет по столбцам, правильно вместо "4" указывать "matrix.GetLength(1)"
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}
PrintArray(matrix);*/







/*int[,] matrix = new int[3, 4]; // тот же метод, но с добавлением в матрицу случайных чисел

void PrintArray(int[,] matr )
{
    for(int i = 0; i < matr.GetLength(0); i++) // отчет по строкам, правильно вместо "3" указывать "matrix.GetLength(0)"
    {
        for(int j = 0; j < matr.GetLength(1); j++) // отчет по столбцам, правильно вместо "4" указывать "matrix.GetLength(1)"
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // интервал [1; 10)
        }
    }
}

PrintArray(matrix);

FillArray(matrix);

Console.WriteLine(); // добавляет отступ

PrintArray(matrix);*/






// Рисунок, без закрашенной середины

/*int[,] pic = new int[,] // есть заданная матрица, массив, кол-во строк и столбцов можно не указывать, если есть фиксированные данные
{
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};


void PrintImage(int[,] image)
{
    for(int i = 0; i < image.GetLength(0); i++)
    {
        for(int j = 0; j < image.GetLength(1); j++)
        {
            // Console.Write($"{image[i, j]} ");
            if(image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");

        }
    Console.WriteLine();
    }
}

void FillImage(int row, int col) // метод, с помощью которого можно закрасить середину рисунка
{
    if(pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col); // метод вызывает сам себя - это и есть рекурсия
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}


PrintImage(pic);
FillImage(13, 13);
PrintImage(pic);*/





// пример функции с факториалом

/*int Factorial(int n)
{
    // 1! = 1, определение факториала
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n - 1);
}

Console.WriteLine(Factorial(3)); // пример, факториал числа 3; 1*2*3 = 6
*/


// пример функции с факториалом, с большими значениями, вместо инт - дабл (т.к. позволяет хранить больший объем информации)

/*double Factorial(int n)
{
    // 1! = 1, определение факториала
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n - 1);
}
for(int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}*/






// Задача по числам Фибоначчи

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)
{
    if(n == 1 || n ==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for(int i = 1; i < 50; i++)
{
    //Console.WriteLine(Fibonacci(i)); или более подробно можно записать как:
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}




