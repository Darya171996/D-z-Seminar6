// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
int[] array = new int[new Random().Next(1, 10)];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.Write($"{array[i]} ");
}
int count = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i] > 0)

    {
        count++;
    }
    Console.WriteLine();
System.Console.WriteLine($"{count} чисел(ла) больше 0 ");