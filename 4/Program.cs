Console.WriteLine("Первое число: ");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int numTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Третье число: ");
int numThree = Convert.ToInt32(Console.ReadLine());
int max = numOne;

if (max < numTwo)
{
  max = numTwo;
}


if (max < numThree)
{
    max = numThree;
}
   Console.WriteLine(max + " это самая макисмальное число из списка, который вы ввели"); 