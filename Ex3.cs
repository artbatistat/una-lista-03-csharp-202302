Console.WriteLine("Digite um número para o valor de 'A': ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite um número para o valor de 'B': ");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite um número para o valor de 'C': ");
double c = Convert.ToDouble(Console.ReadLine());

double discriminante = Math.Pow(b,2) + (-4*a*c);

if(a == 0 && b == 0 && c != 0)
{
    Console.WriteLine("Coeficientes informados incorretamente.");
    Console.ReadLine();
}
else if(a == 0 && b != 0)
{
    Console.WriteLine("Essa é uma equação de primeiro grau.");
    double resultado = (c*(-1))/b;
    Console.WriteLine("O resultado do X é :"+resultado);
    Console.ReadLine();
}
else if(discriminante < 0)
{
Console.WriteLine("Está equação não possui raízes reais.");
Console.ReadLine();
}
else if(discriminante == 0)
{
    Console.WriteLine("Está equação possui duas raízes reais iguais.");

    double x1 = (b*(-1) + Math.Sqrt(Math.Pow(b,2)+(-4*a*c)))/2*a;
    double x2 = (b*(-1) - Math.Sqrt(Math.Pow(b,2)+(-4*a*c)))/2*a;

    Console.WriteLine("O valor do x¹ é: "+x1);
    Console.WriteLine("O valor do x² é: "+x2);
    Console.ReadLine();
}
else if(discriminante > 0)
{
    double x1 = (b*(-1) + Math.Sqrt(Math.Pow(b,2)+(-4*a*c)))/2*a;
    double x2 = (b*(-1) - Math.Sqrt(Math.Pow(b,2)+(-4*a*c)))/2*a;

    Console.WriteLine("O valor do x¹ é: "+x1);
    Console.WriteLine("O valor do x² é: "+x2);
    Console.ReadLine();
}
else
{
Console.WriteLine("Algo deu errado. Verifique os valores inseridos.");
Console.ReadLine();
}
