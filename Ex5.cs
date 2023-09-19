Console.WriteLine("Digite um valor:");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite um valor:");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\tAdição....: + \n\tSubtração....: -\n\tMultiplicação....: *\n\tDivisão....: /\n\tPotência....: ^");
Console.WriteLine("Digite o código referente a operação desejada:");
string operacao = Console.ReadLine();

if(operacao == "+")
{
    double resultado = num1 + num2;
    Console.WriteLine("O resultado é: {0}",resultado);
    Console.ReadLine();
}
else if(operacao == "-")
{
    double resultado = num1 - num2;
    Console.WriteLine("O resultado é: {0}",resultado);
    Console.ReadLine();
}
else if(operacao == "*")
{
    double resultado = num1 * num2;
    Console.WriteLine("O resultado é: {0}",resultado);
    Console.ReadLine();
}
else if(operacao == "/")
{
    double resultado = num1 / num2;
    Console.WriteLine("O resultado é: {0}",resultado);
    Console.ReadLine();
}
else if(operacao == "^")
{
    double resultado = Math.Pow(num1,num2);
    Console.WriteLine("O resultado é: {0}",resultado);
    Console.ReadLine();
}
else
{
Console.WriteLine("Símbolo da operação inválido.");
Console.ReadLine();
}