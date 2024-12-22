using System;

class Program
{
    static void Main()
    {
    Console.WriteLine("Bem Vindo a calculadora");
    Console.WriteLine("Digite o Valor do Aporte Inicial");
    decimal principal = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Digite o Tempo do investimento em Anos");
    int tempo = Convert.ToInt32(Console.ReadLine());
    decimal resultado = 0;
    Console.WriteLine("Selecione uma opcao 1 ou 2");
    int opcao = Convert.ToInt32(Console.ReadLine());
    switch(opcao){
      case 1:
      Console.Write("Digite a taxa de Juros do titulo em %:");
      decimal taxaC = Convert.ToDecimal(Console.ReadLine())/100;
      resultado = principal * (decimal)Math.Pow((double)(1 + taxaC), tempo);
      Console.WriteLine($"O valor acumulado em {tempo} anos com juros compostos: {resultado:C}");
      break;
      default:
      Console.WriteLine("Opção inválida.");
      break;
    }
}
}
