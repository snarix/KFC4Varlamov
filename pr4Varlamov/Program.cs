try
{
    int a;
    do
    {
        Console.WriteLine("Выберите задание от 1 до 3, чтобы выйти введите 0");
        Console.Write("Задание - ");

        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        switch (a)
        {
            case 0:
                {
                    Console.WriteLine("Выход осуществлён");
                }
                break;

            case 1:
                {
                    Console.WriteLine("Введите число: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    int minus = b - 1;
                    int plus = b + 1;
                    Console.Write(minus + "" + b + "" + plus);

                    Console.WriteLine();
                    Console.WriteLine();
                }
                break;

            case 2:
                {
                    Console.Write("Введите размерность массива: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int[] arr = new int[n];
                    Random rnd = new Random();
                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = rnd.Next(10);
                    }

                    Console.WriteLine("Масиив: ");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(arr[i] + " ");
                    }

                    Console.Write("\nВведите число, каждое N-ное из которых нужно уничтожить: ");
                    int m = Convert.ToInt32(Console.ReadLine());

                    int count = n,
                        j = 0,
                        k = 1;
                    while (count > 1)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            if (arr[i] != -1)
                            {
                                if (k % m == 0)
                                {
                                    arr[i] = -1;
                                    count--;
                                }
                                k++;
                            }
                        }

                        while (arr[j] == -1)
                        {
                            j = (j + 1) % n;
                        }
                        j = (j + 1) % n;
                        Console.WriteLine("Массив: [{0}]", string.Join(", ", arr));
                    }
                    Console.WriteLine();
                }
                break;

            case 3:
                {
                    Console.Write("Введите кол-во строк массива - ");
                    int M = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите кол-во столбцов массива - ");
                    int N = Convert.ToInt32(Console.ReadLine());

                    int[,] matrix = new int[M, N];
                    Random rnd = new Random();

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            matrix[i, j] = rnd.Next(0, 10);
                        }
                    }

                    Console.WriteLine("Массив:");
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }

                    int Min;
                    int Temp = 0;
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        Min = matrix[i, 0];
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            if (matrix[i, j] <= Min)
                            {
                                Min = matrix[i, j];
                                Temp = j;
                            }
                        }
                        matrix[i, Temp] = matrix[i, i];
                        matrix[i, i] = Min;
                    }
                    Console.WriteLine();

                    Console.WriteLine("Отсортированный массив:");
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                break;

            default:
                Console.WriteLine("Неверный номер задания");
                break;
        }
    }
    while (a != 0);
}
catch
{
    Console.WriteLine();
    Console.WriteLine("Вводите корректные данные!");
    Console.ReadLine();
}




















