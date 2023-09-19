int num1, num2, num3;

Console.WriteLine("Digite um número:");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite um número:");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite um número:");
num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2 && num1 > num3)
{
Console.WriteLine("Maior número: " + num1);
if(num2 < num3)
{
Console.WriteLine("Menor número: " + num2);
Console.WriteLine("Média aritmética: " + ((num1+num2+num3)/3));
Console.ReadLine();
}
else if(num3 < num2)
{
Console.WriteLine("Menor número: " + num3);
Console.WriteLine("Média aritmética: " + ((num1+num2+num3)/3));
Console.ReadLine();
}
}
else if(num2 > num1 && num2 > num3)
{
Console.WriteLine("Maior número: " + num2);
if(num1 < num3)
{
Console.WriteLine("Menor número: " + num1);
Console.WriteLine("Média aritmética: " + ((num1+num2+num3)/3));
Console.ReadLine();
}
else if(num3 < num1)
{
Console.WriteLine("Menor número: " + num3);
Console.WriteLine("Média aritmética: " + ((num1+num2+num3)/3));
Console.ReadLine();
}
}
else if(num3 > num1 && num3 > num2)
{
Console.WriteLine("Maior número: "+ num3);
if(num1 < num2)
{
Console.WriteLine("Menor número: " + num1);
Console.WriteLine("Média aritmética: " + ((num1+num2+num3)/3));
Console.ReadLine();
}
else if(num2 < num1)
{
Console.WriteLine("Menor número: " + num2);
Console.WriteLine("Média aritmética: " + ((num1+num2+num3)/3));
Console.ReadLine();
}

}