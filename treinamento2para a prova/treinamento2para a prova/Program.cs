using System.ComponentModel.Design;

Console.WriteLine("\n ------ atividade1-----");

int numero1;
int numero2;
Console.WriteLine("digite o primeiro numero inteiro");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("digite o segundo numero inteiro");
numero2 = int.Parse(Console.ReadLine());
int divisão = numero1 - numero2;
Console.WriteLine("a divisão é: " + divisão );

Console.WriteLine("\n ----atividade 2--------");

int idade;
Console.WriteLine("qual a sua idade?");
idade = int.Parse(Console.ReadLine()); // o int.parse pega uma string e tranforma para int


Console.WriteLine("\n ----atividade 3--------");

long visualizações;
Console.WriteLine("quantas vizualizaçoes tem o video?");
visualizações = long.Parse(Console.ReadLine());
long visualizaçõesHoje;
Console.WriteLine("quantas vizualizaçoes foram hoje??");
visualizaçõesHoje = long.Parse(Console.ReadLine());
long soma = visualizações + visualizaçõesHoje;
Console.WriteLine("exibindo as visualizações   : " + soma);

long visualizaçõesTotais = 5000000;

if (visualizaçõesTotais > 50000000) ;
{
    Console.WriteLine("sucesso em visualizações");
}






