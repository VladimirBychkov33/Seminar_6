// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -7, 567, 89, 223-> 3

Console.Clear();
Console.Write($"Введите 1 число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write($"Введите 2 число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write($"Введите 3 число: ");
int num3 = int.Parse(Console.ReadLine());
Console.Write($"Введите 4 число: ");
int num4 = int.Parse(Console.ReadLine());
Console.Write($"Введите 5 число: ");
int num5 = int.Parse(Console.ReadLine());

int[] GetArray(int num)
{
    int[] array = new int[5];
    for (int i = 0; i < 5; i++)
    {
        array[0] = num1;
        array[1] = num2;
        array[2] = num3;
        array[3] = num4;
        array[4] = num5;
        Console.Write($"{array[i]} ");
    }
    return array;
    Console.WriteLine();
}

int[] result = GetArray(5);
Console.WriteLine();

int CountPositive (int[] arr)
{
    int[] massiv = new int[arr.Length]; 
    int count = 0;
    foreach (int element in arr)
    {
        if (element > 0)
        {
            count ++;   
        }
    }
    return count;
}

Console.WriteLine($"Количество цифр больше 0, которые ввел пользователь, равно {CountPositive(result)}");


