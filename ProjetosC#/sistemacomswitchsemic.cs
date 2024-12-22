using System;
namespace Teste
{
    class Program
    {
        static void soma()
        {
            Console.WriteLine("Por favor Informe o primeiro Numero");
            int v1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Por favor Informe o primeiro Numero");
            int v2 = Convert.ToInt16(Console.ReadLine());
            int res;
            res=v1+v2;
            Console.WriteLine("O resultado é {0}", res);
        }
        static void dimi()
        {
            Console.WriteLine("Por favor Informe um numero");
            int v3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Por favor Informe um numero");
            int v4 = Convert.ToInt16(Console.ReadLine());
            int res;
            res=v3-v4;
            Console.WriteLine("O resultado é {0}", res);
        }
        static void mult()
        {
            Console.WriteLine("Por favor Informe o primeiro Numero");
            int v3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Por favor Informe o primeiro Numero");
            int v4 = Convert.ToInt16(Console.ReadLine());
            int res;
            res=v3*v4;
            Console.WriteLine("O resultado é {0}", res);
        }
        static void div()
        {
            Console.WriteLine("Por favor Informe o primeiro Numero");
            int v3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Por favor Informe o primeiro Numero");
            int v4 = Convert.ToInt16(Console.ReadLine());
            int res;
            res=v3/v4;
            Console.WriteLine("O resultado é {0}", res);
        }
        static void Main()
        {
            int menu;
            Console.Write("Digite uma opção de 1 a 3: ");
            menu=Convert.ToInt16(Console.ReadLine());
            while(menu!=4){
            switch(menu)
            {
            case 1:
                soma();  //chama a função similar a JS
                break;
            case 2:
                dimi(); //chama a função similar a JS
                break;
            case 3:
                mult(); //chama a função similar a JS
                break; 
            case 4:
                div(); //chama a função similar a JS
                break; 
            default:
                Console.WriteLine("Opção inválida.");
                break;
            }
        }
    }
}
}
