Console.WriteLine("\t1: Calcular e imprimir o perímetro do círculo");
Console.WriteLine("\t2: Calcular e imprimir a área do círculo");
Console.WriteLine("\t3: Calcular e imprimir o volume da esfera");

Console.WriteLine("Selecione o código da operação a ser executado:");
int operacao = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Digite o valor do raio:");
int r = Convert.ToInt32(Console.ReadLine());

if(operacao == 1)
{
    double resultado = 2 * Math.PI * r;
    Console.WriteLine("\tO perímetro do círculo é: {0}",Math.Round(resultado,2));
    Console.ReadLine();
}
else if(operacao == 2)
{
    double resultado = Math.PI * Math.Pow(r,2);
    Console.WriteLine("\tA área do círculo é: {0}",Math.Round(resultado,2));
    Console.ReadLine();
}
else if(operacao == 3)
{
    double resultado = (4 * Math.PI * Math.Pow(r,3))/3;
    Console.WriteLine("\tO volume da esfera é: {0}",Math.Round(resultado,2));
    Console.ReadLine();
}
else
{
Console.WriteLine("Código da operação é inválido");
Console.ReadLine();
}