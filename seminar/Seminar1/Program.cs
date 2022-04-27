/*Console.Write("Ведите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int sqr = number2 / number1;
if (sqr == number1)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}*/

/*Console.Write("Ведите число от 1 до 7: ");
int numberOfDay = Convert.ToInt32(Console.ReadLine());
if (numberOfDay == 1) Console.WriteLine("Понедельник");
else if (numberOfDay == 2) Console.WriteLine("Вторник");
else if (numberOfDay == 3) Console.WriteLine("Среда");
else if (numberOfDay == 4) Console.WriteLine("Четверг");
else if (numberOfDay == 5) Console.WriteLine("Пятница");
else if (numberOfDay == 6) Console.WriteLine("Суббота");
else if (numberOfDay == 7) Console.WriteLine("Воскресенье");
else Console.WriteLine("Это не день недели");*/


Console.Write("Ведите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int nMinus = n * (-1);
while (nMinus <= n)
{
    Console.Write($"{nMinus}, ");
    nMinus++;
}


/*Console.Write("Ведите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n % 10);*/
