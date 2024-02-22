// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

/// <summary>
/// Метод печается все натуральные числа с M до N
/// </summary>
/// <param name="start"> Начальное число (M) </param>
/// <param name="end"> Конечное число (N) </param>
// void ShowNumbers(int start, int end)
// {
//     if (start == end)
//     {
//         Console.Write(end);
//         return;
//     }
//     Console.Write($"{start} ");
//     ShowNumbers(start + 1, end);
// }

// Console.Clear();
// Console.Write("Введите начальную точку -> ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите конечную точку -> ");
// int N = Convert.ToInt32(Console.ReadLine());

// ShowNumbers(M,N);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// /// <summary>
// /// Нахождение функции Акермана 
// /// </summary>
// /// <param name="m">1 переменная </param>
// /// <param name="n">2 переменная </param>
// /// <returns></returns>
// int AkermanRec (int n, int m)
// {
//     if (n == 0)
//     {
//         return m + 1;
//     }
//     else if (m == 0)
//     {
//         return AkermanRec(n-1, 1);
//     }
//     return AkermanRec(n-1, AkermanRec(n,m-1));
// }

// Console.Clear();
// Console.Write("Введите переменную n -> ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите переменную m -> ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(AkermanRec(n,m));


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

// /// <summary>
// /// Создание рандомного массива
// /// </summary>
// /// <param name="array"></param>
// /// <returns></returns>
// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         array[i] = rnd.Next(101);
//     }
//     return array;
// }

// /// <summary>
// /// Печать массива
// /// </summary>
// /// <param name="array"></param>
// void PrintArray(int[] array, int i = 0)
// {
//     if (i < array.Length)
//     {
//         Console.Write($"[{array[i]}] \t");
//         PrintArray(array, i + 1);
//     }
// }

// /// <summary>
// /// Разворот массива
// /// </summary>
// /// <param name="array"> Массив </param>
// /// <param name="firstIndex"> Первый индекс массива </param>
// /// <param name="lastIndex"> Последний индекс массива </param>
// /// <returns></returns>
// void ReverseArray(int[] array, int firstIndex, int lastIndex)
// {
//     if (lastIndex >= firstIndex)
//     {
//         Console.Write($"[{array[lastIndex]}]" + " ");
//         ReverseArray(array,firstIndex , lastIndex -1);
//     }
// }

// Console.Clear();
// Console.Write("Enter size array -> ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Create first array");
// int[] array = CreateArray(size);
// PrintArray(array);
// Console.WriteLine("\n");
// Console.Write("Reverse array -> ");
// ReverseArray(array, 0, array.Length-1);

123