// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.(Math.Pow использовать нельзя!!!)
// int Develop(int a, int b){
//     int pow = 1;
//     for (int i = 0; i < b; i++)
//     {
//         pow = pow * a;
//     }
//     return pow;
// }
// Console.Write("Enter A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int res = Develop(a,b);
// Console.WriteLine($"Result is equal to {res}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.(Массивы и строки использовать нельзя!!!)
// int SummNumbers(int num){
//     int count = 0;
//     while (num>0)
//     {
//         count = count + num % 10;
//         num = num / 10;
//     }
//     return count;
// }
// Console.Write("Enter your number: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// int res = SummNumbers(numb);
// Console.WriteLine($"Сумма цифр чмсла {numb} равен {res}");

// Задача 29: Напишите программу, которая задаёт массив из произвольного кол-ва элементов и выводит их на экран.
int[] Massive(int numb){
    int [] arr = new int [numb];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,100);
    }
    return arr;
}
void ShowArray(int[] arr){
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{ arr[i] } ");
    }
}
Console.Write("Enter a size: ");
int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numbers: ");
// int number = Convert.ToInt32(Console.ReadLine());
ShowArray(Massive(size));