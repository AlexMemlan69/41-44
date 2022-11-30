//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 4


Console.Write("Введите числа");
int numb = Convert.ToInt32(Console.ReadLine());
// преобразовали число
int[] array = new int [numb];
//добавили в массив
int PositiveCount(int count)
{
    int count0fPositive = 0;
    for(int i = 0; i < count; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
        {
            count0fPositive += 1;

        }
        Console.WriteLine(string.Join("," , array));
        
    }
    return count0fPositive;
}
int posCount = PositiveCount(numb);
Console.Write($"Количество положительных чисел = {posCount} ");