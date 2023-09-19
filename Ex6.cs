Console.WriteLine("Digite um número inteiro:");
int num1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite outro número inteiro:");
int num2 = Convert.ToInt16(Console.ReadLine());

Random random = new Random();

int menor,maior;

if(num1 < num2)
{
    menor = num1;
    maior = num2;
    int numrandom = random.Next(menor,maior);
    Console.WriteLine("\tO número do sorteio é: {0}",numrandom);
    if(numrandom % 2 == 0)
    Console.WriteLine("\tO número sorteado é par.");
    else
    Console.WriteLine("\tO número sorteado é ímpar.");

    Console.ReadLine();
}
else if(num2 < num1)
{
    menor = num2;
    maior = num1;
    int numrandom = random.Next(menor,maior);
    Console.WriteLine("\tO número do sorteio é: {0}",numrandom);
    if(numrandom % 2 == 0)
    Console.WriteLine("\tO número sorteado é par.");
    else
    Console.WriteLine("\tO número sorteado é ímpar.");

    Console.ReadLine();
}
else
{
    Console.WriteLine("Os números informados são iguais.");
    Console.ReadLine();    
}