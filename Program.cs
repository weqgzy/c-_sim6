//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.//

Console.Write("Введите числа(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = arr.Count(x => x > 0);
if (count <= 0)
{
   System.Console.WriteLine("чисел больше нуля нет"); 

}
else Console.WriteLine($"числел больше нуля: {count}");