using System;

public class calculadora
{
    static void rend(){
        Console.WriteLine("Favor Insira o rendimento da aplicacao até o momento");
        decimal rend = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Favor Insira o valor da Aplicação Inicial");
        decimal valorIni = Convert.ToDecimal(Console.ReadLine());
        decimal res=rend*100/valorIni;
        Console.Write("O Juros até o momento é{0}",res);
    }
    public static void Main(string[] args)
    {
        int menu;
        Console.WriteLine("===Bem vindo a Calculadora===");
        Console.WriteLine("Digite a opção Desejada");
        menu=Convert.ToInt16(Console.ReadLine());
         while(menu!=4){
         switch(menu){
              case 1:
              rend();  //chama a função similar a JS
              break;
              default:
              Console.WriteLine("Opção inválida.");
              break;
         }
             
         }
       
    }
}
