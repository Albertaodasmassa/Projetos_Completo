using System;

class Program
{
    static void Main()
    {
    Console.WriteLine("=======Bem Vindo a calculadora Pos Fixado======");
    Console.Write("Digite o Valor do Aporte Inicial em R$: ");
    decimal principal = Convert.ToDecimal(Console.ReadLine());
    Console.Write("Digite o Tempo do investimento em Anos:");
    int tempo = Convert.ToInt32(Console.ReadLine());
    decimal resultado = 0;
    Console.Write("Digite a taxa de Juros do titulo em %:");
    decimal taxaC = Convert.ToDecimal(Console.ReadLine())/100;
    Console.Write("Digite o Valor da taxa CDI Atual:");
    decimal taxacdi = Convert.ToDecimal(Console.ReadLine())/100;
    decimal res = taxaC+taxacdi;
    resultado = principal * (decimal)Math.Pow((double)(1 + res), tempo);
    Console.WriteLine($"O Valor acumulado em {tempo} anos, sera R$: {resultado:F2}");
    Console.WriteLine("====Obrigado Por usar a Calculadora dos Guri!!======");
    }
}
