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
//Task25();
Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
void Task27()
{
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

Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.");
