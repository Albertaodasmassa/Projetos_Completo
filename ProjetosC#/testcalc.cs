using System;

class Program
{
    static void Main()
    {
    Console.WriteLine("=======Bem Vindo a calculadora======");
    Console.Write("Digite o Valor do Aporte Inicial:");
    decimal principal = Convert.ToDecimal(Console.ReadLine());
    Console.Write("Digite o Tempo do investimento em Anos:");
    int tempo = Convert.ToInt32(Console.ReadLine());
    decimal resultado = 0;
    Console.WriteLine("Selecione uma opcao 1 ou 2");
    int opcao = Convert.ToInt32(Console.ReadLine());
    switch(opcao){
     case 1:
      Console.Write("Digite a taxa de Juros do titulo em %:");
      decimal taxaC = Convert.ToDecimal(Console.ReadLine())/100;
      Console.Write("Digite a taxa do IPCA atual:");
      decimal taxaipca = Convert.ToDecimal(Console.ReadLine())/100;
      decimal txa = taxaC + taxaipca;
      resultado = principal * (decimal)Math.Pow((double)(1 + txa), tempo);
      Console.WriteLine($"O valor acumulado em {tempo} anos, com juros do ativo sera R$: {resultado:F2}");
      break;
      default:
      Console.WriteLine("Opção inválida.");
      break;
    }
}
}
