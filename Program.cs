
// summation of the numbers from 1+2+34....

int sum = 0;

for (int i = 0 ; i <=100 ;  i++ )
{
    sum = sum + i; // or sum+i;
}
Console.WriteLine(sum);


Console.WriteLine("---------------------");

Console.WriteLine("You can sum numbers from the first number to the last number");

Console.Write("Enter the first number number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int sum1 = 0;

for (int i = num1 ; i <= num2 ; i++)
{
    sum1 = sum1 + i; // or sum+i;
}
Console.WriteLine( "The summation is: " + sum1);