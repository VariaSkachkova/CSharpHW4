void Task25()
{
Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.WriteLine("Введите число, которое нужно возвести в степень: ");
int num1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine("Введите степень, в которую нужно возвести число: ");
int num2 = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine($"Число {num1} в степени {num2}: {FindPower(num1, num2)}");
}
int FindPower(int num1, int num2)
{
    int power = 1;
    int count = 1;
    while (count <= num2)
    {
        power = power*num1;
        count++;
    }
    return power;
}
Task25();

void Task27()
{
    Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());    
    Console.WriteLine ($"Сумма цифр в числе {number}: {SumUpDigits(number)}");

}
int SumUpDigits(int number)
{
    int count = 1;
    int sum = number%10;
    while (number/10 > 0)
    {
        
        count++;
        number = number/10;       
        sum = sum + number%10;
    }
    return sum;
}
Task27();

void Task29 ()
{
    Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.");
    int size = 8;
    int[] array1 = new int[size];
    array1 = FillArray(size);
    int[] array2 = new int[size];
    array2 = FillArray(size);
    
int [] FillArray(int size)
{
    int[] fillArray = new int[size];
    Random random = new Random();
    for (int i = 0; i <fillArray.Length; i++)
    {
        fillArray[i] = random.Next(-1000,1000);
        
    }
    return fillArray;
    
}
void PrintArray (int [] array)
{
    for (int i = 0; i <array.Length; i++)
    {
        
        Console.Write(array[i] + " ");
        
    }
    Console.WriteLine();
}

void SortBySelection (int [] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (Math.Abs(array[j]) < Math.Abs(array[minIndex])) 
            {
                minIndex = j;
            }
        }

        int temp = array[i];
        array[i] = array[minIndex];
        array[minIndex] = temp;
    }
}
Console.WriteLine("Вывод первого заполненного массива:");
PrintArray(array1);
SortBySelection(array1);
Console.WriteLine("Вывод отсортированного по модулю массива (сортировка выбором):");
PrintArray(array1);
Console.WriteLine("Вывод второго заполненного массива:");
FillArray(size);
PrintArray(array2);
SortByBubble (array2);
Console.WriteLine("Вывод отсортированного по модулю массива (сортировка пузырьком):");
PrintArray(array2);
}
Task29 ();

void SortByBubble (int [] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (Math.Abs(array[j]) < Math.Abs(array[minIndex])) 
            {
                int temp = array[j];
                array[j] = array[minIndex];
                array[minIndex] = temp;
            }
        }

    }

}


