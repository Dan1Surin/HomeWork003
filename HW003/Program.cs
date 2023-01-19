// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем
int[] FillArray(int size)
{
    int[] arr = new int[size]; //массив знает свою длинну если выделить под него память такой операцией
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i} элемент");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i] + " ");
    }
}

int[] array = FillArray(8);
Console.WriteLine(string.Join(",",array));