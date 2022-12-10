// Урок 8. Двумерные массивы. Продолжение
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] FillArray(int m, int n)   // функция задает массив двумерный из случайных целых чисел от 0 до 9 
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(0, 10);            
//         }
//     }
//     return array;
// }
// void PrintArray(int[,] array)    // функция выводит массив на экран
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] OrderedArray(int[,] array) // функция возвращает массив упорядочив строки по убыванию во входящем массиве
// {
//     int temp; // временная переменная для перестановки элементов в строке
//     int m = array.GetLength(0);
//     int n = array.GetLength(1);
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             for (int k = 0; k < n - j - 1; k++)
//             {
//                 if (array[i, k] < array[i, k+1]) // если справа элемент больше, то меняем элементы местами
//                 {                               // проделываем с элементами строки пока не будут сравнены все элементы в строке
//                     temp = array[i, k];
//                     array[i, k] = array[i, k+1];
//                     array[i, k+1] = temp;
//                 }
//             }        
//         }
//     }
//     return array; // возвращаем полученный массив
// }
// запрашивае у пользователя ввода размера массива
// Console.WriteLine();
// Console.Write("Введите количество строк матрицы: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов матрицы: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine();
// int[,] array = FillArray(m, n);
// выводим исходный массив на экран
// Console.WriteLine("Исходная матрица");
// PrintArray(array);
// Console.WriteLine();
// выводим полученны массив на экран
// Console.WriteLine("Упорядоченная матрица (строки по убыванию)");
// PrintArray(OrderedArray(array));
// Console.WriteLine();

// ----------------------------------------------

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] FillArray(int m, int n)  // эта функция задает двухмерный массив случайными числами, 
// {                              // аргументами выступают m - количество строк, n - количество столбцов
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(0, 10);            
//         }
//     }
//     return array;
// }
// void PrintArray(int[,] array)   // стандартная функция вывода массива на экран
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// int IndexMinRow(int[,] array)   // функция которая подсчитывает суммы в каждой строке, сравнивает их выводит индекс строки с минимальной суммой
// {
//     int min = 0;  // переменная для наименьшей суммы строки в массиве
//     int iMin = 0;  // индекс соответствующий минимальной сумме строки в массиве
//     int tempSum = 0;  // временное хранилище суммы элементов текущей строки
//     int m = array.GetLength(0);
//     int n = array.GetLength(1);
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             tempSum += array[i, j]; // суммируем все элементы текущей строки и передаем значение переменной tempSum
//         }
//         if (i == 0) min = tempSum; // условие для первоначального задания переменной min, оно будет равно сумме элементов первой строки (индекс 0)
//         else if (tempSum < min)    // далее находим min и iMin
//         {
//             min = tempSum;
//             iMin = i;            
//         }
//         tempSum = 0;
//     }
//     return iMin;
// }
// и выводим полученный результат на экран используя наши функции
// Console.WriteLine();
// Console.Write("Введите количество строк матрицы: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов матрицы: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine();
// int[,] array = FillArray(m, n);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine($"Номер строки с наименьшей суммой элементов = {IndexMinRow(array) + 1}");
// Console.WriteLine();

// ----------------------------------------------

// Задача 58: Задайте два двумерных массива (от 0 до 10). Напишите программу, которая будет находить произведение двух массивов (поэлементное).
// Например, даны 2 массива:
// 2 4
// 3 2

// 3 4
// 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

// int[,] FillArray(int m, int n) // функция которая создает двухмерный массив с аргументами - количество строкб количество столбцов
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(0, 10);      // заполняем наш массив случайными целыми числами от 0 до 9      
//         }
//     }
//     return array;
// }
// void PrintArray(int[,] array) // стандартная функция вывода массива на экран
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] ProductOfArray(int[,] array1, int[,] array2) // несложная функция, которая находит произведение двух массивов (поэлементно) 
// {                                                   // и возвращает полученный массив
//     int m = array1.GetLength(0);
//     int n = array1.GetLength(1);
//     int[,] productArray = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             productArray[i, j] = array1[i, j] * array2[i, j];  // элемент результирующего массиву равен произведению элементов первого и второго массивов
//         }
//     }
//     return productArray;
// }
// пользователь вводит значения аргументов m и n
// Console.WriteLine();
// Console.Write("Введите количество строк матрицы: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов матрицы: ");
// int n = int.Parse(Console.ReadLine());
// выводим матрицу 1 на экран
// Console.WriteLine();
// int[,] array1 = FillArray(m, n);
// Console.WriteLine("матрица 1");
// PrintArray(array1);
// выводим матрицу 2 на экран
// Console.WriteLine();
// int[,] array2 = FillArray(m, n);
// Console.WriteLine("матрица 2");
// PrintArray(array2);
// выводим полученную матрицу на экран
// Console.WriteLine();
// Console.WriteLine("Произведение матрицы 1 и матрицы 2 (поэлементное): ");
// PrintArray(ProductOfArray(array1, array2));
// Console.WriteLine();

// ----------------------------------------------

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[, ,] FillArray(int m, int n, int l) // стандартная функция для создания трехмерного массива заполняя ее случайными двухзначными целыми числами
// {
//     Random rnd = new Random();
//     int[, ,] array = new int[m, n, l];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             for (int k = 0; k < l; k++)
//             {
//                 array[i, j, k] = rnd.Next(10, 100);    
//             }
//         }
//     }
//     return array;
// }
// void PrintArray(int[, ,] array)  // функция которая выводит трехмерный массив построчно с указанием индекса элемента
// {
//     for (int k = 0; k < array.GetLength(2); k++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write(array[i, j, k] + $"({i},{j},{k}) ");
//             }
//             Console.WriteLine();
//         }
//     }
// }
// команды и вызовы для вывода нашего трехмерного массива на экран
// Console.WriteLine();
// Console.WriteLine("Задайте размерность трехмерного массива, указав 3 ее параметра m x n x l");
// Console.Write("m: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("n: ");
// int n = int.Parse(Console.ReadLine());
// Console.Write("l: ");
// int l = int.Parse(Console.ReadLine());
// Console.WriteLine();
// int[, ,] array = FillArray(m, n, l);
// PrintArray(array);
// Console.WriteLine();

// ----------------------------------------------

// Доп.Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] array)  // стандартная уже функция для вывода массива на экран,
{ // за исключением доп условий, см. в теле функции
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   // добавим доп условий для того чтобы матрица в консоли отображалась ровненько
            if (array[i, j] < 10) Console.Write("  " + array[i, j] + " ");      // если число из одной цифры - добавим 2 пробела перед ним
            else if (array[i, j] < 100) Console.Write(" " + array[i, j] + " "); // если число двузначное - добавим 1 пробел перед ним
            else Console.Write(array[i, j] + " ");                              // если число трехзначное - не ставим пробелов перед ним
        }
        Console.WriteLine();
    }
}
int[,] HelicalArrayFill(int getLength) // функция задающая массив и заполняющая его по спирали
{
    int elementArray = 0; // переменная которая будет присваиваться элементу массива
    int n = getLength;   // переменной n присвоим значение размерности массива, для упрощения записи в дальнейшем использовании
    int[,] helicalArray = new int[n, n]; // задаем новый массив размером n на n
    int i = 0; // i - индекс строки
    int j = 0; // j - индекс столбца
    for (int m = 1; m <= (n + 1)/2; m++)  // m - переменная которая означает номер "витка спирали" от внешнего к внутреннему квадрату
    {                          
        i = m - 1;   // означает что мы совершаем движение по верхней строке - по верхнему краю в текущем "витке"
        for (j = m - 1; j <= n-m; j++)         // это означает что мы двигаемся слева направо по всему верхнему краю текущего "витка"
        {
            elementArray++;
            helicalArray[i, j] = elementArray; // присваиваем текущему элементу массива текущее значение переменной elementArray
        }
        j = n - m;   // означает что мы совершаем движение по правому столбцу - по правому краю в текущем "витке"
        for (i = m; i <= n-m; i++)             // это означает что мы двигаемся сверху вниз по всему правому краю текущего "витка"
        {
            elementArray++;
            helicalArray[i, j] = elementArray;
        }
        i = n - m;   // означает что мы совершаем движение по нижней строке - по нижнему краю в текущем "витке"
        for (j = n - m - 1; j >= m - 1; j--)   // это означает что мы двигаемся справа налево по всему нижнему краю текущего "витка"
        {
            elementArray++;
            helicalArray[i, j] = elementArray;
        }
        j = m - 1;   // означает что мы совершаем движение по левому столбцу - по левому краю в текущем "витке"
        for (i = n - m - 1; i >= m; i--)       // это означает что мы двигаемся снизу вверх по всему левому краю текущего "витка", завершая этот виток
        {
            elementArray++;
            helicalArray[i, j] = elementArray;
        }   
    }
    return helicalArray; // возвращаем полученный массив
}
// стандартные команды и вызовы функций для вывода полученного массива на экран
Console.WriteLine();
Console.Write("Введите размерность матрицы (n x n), n = ");
int getLength = int.Parse(Console.ReadLine());
int[,] helicalArray = HelicalArrayFill(getLength);
Console.WriteLine();
PrintArray(helicalArray);
Console.WriteLine();