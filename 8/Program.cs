Console.WriteLine("Введите число: ");
int numOne = Convert.ToInt32(Console.ReadLine());
int numA = 1;
Console.WriteLine("Все четные числа от 0 до " + numOne + ":");
if (numOne < 2) 
{
    Console.WriteLine("Четных чисел нет");
}

while (numA <= numOne)
{
    if (numA % 2 == 0)
    {
         Console.WriteLine(numA + " ");
    }
    numA = numA + 1;

}
