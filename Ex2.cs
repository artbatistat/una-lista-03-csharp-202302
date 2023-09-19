using System.Net;

Console.WriteLine("\t1- Barra de chocolate.....:R$5,00");
double chocolate = 5.00;
Console.WriteLine("\t2- Coca-cola lata.....:R$3,00");
double coca = 3.00;
Console.WriteLine("\t3- Redbull.....:R$7,00");
double redbull = 7.00;
Console.WriteLine("\t4- Bala Fini.....:R$6,00");
double fini = 6.00;
Console.WriteLine("\t5- Barra de cereal.....:R$2,00");
double cereal = 2.00;

Console.WriteLine("Digite o número do produto:");
int nmrProduto = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Valor depositado na máquina:");
double valor = Convert.ToDouble(Console.ReadLine());

if(nmrProduto == 1)
{
    if(valor < chocolate)
    {
        Console.WriteLine("Quantia depositada é insuficiente para realizar a compra.");
    }
    else
    {
    Console.WriteLine("Produto selecionado : Barra de chocolate");
    double troco = valor-chocolate;
    Console.WriteLine("\tValor do troco: {0:c}" , troco);
    
    double i = troco;
    int nota50 = 0;
    int nota20 = 0;
    int nota10 = 0;
    int nota5 = 0;
    int nota2 = 0;
    int moeda1 = 0;

    while(i > 0)
    {
        if(i >= 50){
        nota50++;
        i-= 50;
        }
        else if(i >= 20){
        nota20++;
        i -= 20;
        }
        else if(i >= 10){
        nota10++;
        i -= 10;
        }
        else if(i >= 5){
        nota5++;
        i -= 5;
        }
        else if(i >= 2){
        nota2++;
        i -= 2;
        }
        else if(i <= 2){
        moeda1++;
        i -= 1;
        }
        else{
        break;
        }
        
    }
    Console.WriteLine("\tNota de 50: {0}",nota50);
    Console.WriteLine("\tNota de 20: {0}",nota20);
    Console.WriteLine("\tNota de 10: {0}",nota10);
    Console.WriteLine("\tNota de 5: {0}",nota5);
    Console.WriteLine("\tNota de 2: {0}",nota2);
    Console.WriteLine("\tMoeda de 1: {0}",moeda1);
    Console.ReadLine();
    }
}
else if (nmrProduto == 2)
{

    if(valor < coca)
    {
        Console.WriteLine("Quantia depositada é insuficiente para realizar a compra.");
    }
    else
    {
    Console.WriteLine("Produto selecionado : Coca-cola Lata");
    double troco = valor-coca;
    Console.WriteLine("\tValor do troco: {0:c}" , troco);
    
    double i = troco;
    int nota50 = 0;
    int nota20 = 0;
    int nota10 = 0;
    int nota5 = 0;
    int nota2 = 0;
    int moeda1 = 0;

    while(i > 0)
    {
    if(i >= 50){
        nota50++;
        i-= 50;
        }
        else if(i >= 20){
        nota20++;
        i -= 20;
        }
        else if(i >= 10){
        nota10++;
        i -= 10;
        }
        else if(i >= 5){
        nota5++;
        i -= 5;
        }
        else if(i >= 2){
        nota2++;
        i -= 2;
        }
        else if(i <= 2){
        moeda1++;
        i -= 1;
        }
        else{
        break;
        }
        
    }
    Console.WriteLine("\tNota de 50: {0}",nota50);
    Console.WriteLine("\tNota de 20: {0}",nota20);
    Console.WriteLine("\tNota de 10: {0}",nota10);
    Console.WriteLine("\tNota de 5: {0}",nota5);
    Console.WriteLine("\tNota de 2: {0}",nota2);
    Console.WriteLine("\tMoeda de 1: {0}",moeda1);
    Console.ReadLine();
    }
}
else if (nmrProduto == 3)
{

    if(valor < redbull)
    {
        Console.WriteLine("Quantia depositada é insuficiente para realizar a compra.");
    }
    else
    {

    Console.WriteLine("Produto selecionado : Redbull");
    double troco = valor-redbull;
    Console.WriteLine("\tValor do troco: {0:c}" , troco);
    
    double i = troco;
    int nota50 = 0;
    int nota20 = 0;
    int nota10 = 0;
    int nota5 = 0;
    int nota2 = 0;
    int moeda1 = 0;

    while(i > 0)
    {
    if(i >= 50){
        nota50++;
        i-= 50;
        }
        else if(i >= 20){
        nota20++;
        i -= 20;
        }
        else if(i >= 10){
        nota10++;
        i -= 10;
        }
        else if(i >= 5){
        nota5++;
        i -= 5;
        }
        else if(i >= 2){
        nota2++;
        i -= 2;
        }
        else if(i <= 2){
        moeda1++;
        i -= 1;
        }
        else{
        break;
        }
        
    }
    Console.WriteLine("\tNota de 50: {0}",nota50);
    Console.WriteLine("\tNota de 20: {0}",nota20);
    Console.WriteLine("\tNota de 10: {0}",nota10);
    Console.WriteLine("\tNota de 5: {0}",nota5);
    Console.WriteLine("\tNota de 2: {0}",nota2);
    Console.WriteLine("\tMoeda de 1: {0}",moeda1);
    Console.ReadLine();
    }
}
else if (nmrProduto == 4)
{

    if(valor < fini)
    {
        Console.WriteLine("Quantia depositada é insuficiente para realizar a compra.");
    }
    else
    {

    Console.WriteLine("Produto selecionado : Bala Fini");
    double troco = valor-fini;
    Console.WriteLine("\tValor do troco: {0:c}" , troco);

    double i = troco;
    int nota50 = 0;
    int nota20 = 0;
    int nota10 = 0;
    int nota5 = 0;
    int nota2 = 0;
    int moeda1 = 0;

    while(i > 0)
    {
    if(i >= 50){
        nota50++;
        i-= 50;
        }
        else if(i >= 20){
        nota20++;
        i -= 20;
        }
        else if(i >= 10){
        nota10++;
        i -= 10;
        }
        else if(i >= 5){
        nota5++;
        i -= 5;
        }
        else if(i >= 2){
        nota2++;
        i -= 2;
        }
        else if(i <= 2){
        moeda1++;
        i -= 1;
        }
        else{
        break;
        }
        
    }
    Console.WriteLine("\tNota de 50: {0}",nota50);
    Console.WriteLine("\tNota de 20: {0}",nota20);
    Console.WriteLine("\tNota de 10: {0}",nota10);
    Console.WriteLine("\tNota de 5: {0}",nota5);
    Console.WriteLine("\tNota de 2: {0}",nota2);
    Console.WriteLine("\tMoeda de 1: {0}",moeda1);
    Console.ReadLine();
        
    }
}
else if (nmrProduto == 5)
{

    if(valor < cereal)
    {
        Console.WriteLine("Quantia depositada é insuficiente para realizar a compra.");
    }
    else
    {

    Console.WriteLine("Produto selecionado : Barra de Cereal");
    double troco = valor-cereal;
    Console.WriteLine("\tValor do troco: {0:c}" , troco);
    
    double i = troco;
    int nota50 = 0;
    int nota20 = 0;
    int nota10 = 0;
    int nota5 = 0;
    int nota2 = 0;
    int moeda1 = 0;

    while(i > 0)
    {
    if(i >= 50){
        nota50++;
        i-= 50;
        }
        else if(i >= 20){
        nota20++;
        i -= 20;
        }
        else if(i >= 10){
        nota10++;
        i -= 10;
        }
        else if(i >= 5){
        nota5++;
        i -= 5;
        }
        else if(i >= 2){
        nota2++;
        i -= 2;
        }
        else if(i <= 2){
        moeda1++;
        i -= 1;
        }
        else{
        break;
        }

    }
    Console.WriteLine("\tNota de 50: {0}",nota50);
    Console.WriteLine("\tNota de 20: {0}",nota20);
    Console.WriteLine("\tNota de 10: {0}",nota10);
    Console.WriteLine("\tNota de 5: {0}",nota5);
    Console.WriteLine("\tNota de 2: {0}",nota2);
    Console.WriteLine("\tMoeda de 1: {0}",moeda1);
    Console.ReadLine();
        
    }
}
else
Console.WriteLine("Número inserido inválido.");

