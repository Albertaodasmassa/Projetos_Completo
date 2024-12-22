using System;
namespace Teste
{
    class Program
    {
        static void calc()
        {
            Console.WriteLine("Por favor o Valor Inicial Aplicado: ");
            double valorIni = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Cupom do ativo: ");
            double juros = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Prazo do cupom: ");
            double tempo = double.Parse(Console.ReadLine());
            double divJuros = juros/100;
            double res = valorIni*(1+divJuros);
            double res2 = Math.Pow(res,tempo);
            double res3 = res2 - valorIni;
            Console.WriteLine("O Valor Será{0}",res2);
            Console.WriteLine("O Valor do juros será{0}",res3);
        }
        static void Main()
        {
            int menu;
            Console.Write("Selecione uma opcao 1 a 3: ");
            menu=Convert.ToInt16(Console.ReadLine());
            while(menu!=4){
            switch(menu)
            {
            case 1:
                calc();  //chama a função similar a JS
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
            }
        }
    }
}
}
