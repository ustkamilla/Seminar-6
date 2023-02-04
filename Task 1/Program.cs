/*
Задача 1: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int InputInt(string message)
{
    System.Console.WriteLine($"{message}");
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int len)
{
    System.Console.WriteLine("Введите числа:");
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int len = InputInt("Сколько чисел вы хотите ввести?");
int[] array = CreateArray(len);
System.Console.WriteLine($"Вы ввели {CountPositiveNumbers(array)} числа (чисел) больше 0.");
