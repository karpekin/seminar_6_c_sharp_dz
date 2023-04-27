// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] array = new int[5];
int i = 0;
int sum = 0;
while (true)
{
    Console.Write("Ведите число: ");
    array[i]= Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0)
        sum = sum + 1;  
    if (i == 4)
        break;
    i++;
}
Console.WriteLine(String.Join(",",array));
Console.WriteLine(sum);