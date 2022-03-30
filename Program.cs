// 25.Напишитн цикл, который на вход принимает чило ( А.В) и возводит число А в натуральный степень В.

// System.Console.WriteLine(" число A ");
// int A = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(" число B ");
// int B = Convert.ToInt32(Console.ReadLine());
// int C = 1;

// for (int i = 1; i <= B; i++)
// {
//     C = C * A;
// }
// System.Console.WriteLine(C);


/// Задача 29.Напишите программу которая выводит массив из 8 элементолв,
// заполненный нулями и единицами в случайном порядке.

// int [] array = new int [8];
// Random random = new Random();
// for (int i = 0; i <8; i++)
// {
//      array[i] = random.Next (9);
//      Console.Write (array[i] + " ");
// }
//  Console.WriteLine();

 // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//  Console.WriteLine("Введите число");
// string number = Convert.ToString(Console.ReadLine());
// string s = number.ToString();
// Console.WriteLine(s.Length);

 // Задача 27: другой вариант.

System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
void Length(int number)
{
    int count = 0;
    while (number > 0 )
    {
        number =  number / 10;
        count++; 
    }
System.Console.WriteLine(count);
}
Length(number);
