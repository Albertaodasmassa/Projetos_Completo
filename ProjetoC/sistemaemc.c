#include <stdio.h>
#include <stdlib.h>
#include <math.h>
int main () {
   int opcao=0.0;
   printf("Digite a opcao\n 1-Calculadora de Juros\n 2- Calculadora de rendimento aplicao\n");
   scanf("%d",&opcao);

   void calc()
   {
       double rend,res,valorini;
       printf("===Bem vindo a calculadora\n===");
       printf("Digite o valor do rendimento:\n");
       scanf("%lf",&rend);
       printf("Digite o valor o inicial da aplicacao:\n");
       scanf("%lf",&valorini);
       res = (rend*100)/valorini;
       printf("O Valor Inicial%.2lf\n",res);
   }
   void calc_rf()
   {
       double valorInicial, valorFuturo, juros,jurosdiv,tempo,impostos,vartempo;
       printf("===Bem vindo a calculadora===\n");
       printf("Digite o valor que deseja Investir:\n");
       scanf("%lf",&valorInicial);
       printf("Digite o tempo que deseja investir:\n");
       scanf("%lf",&tempo);
       printf("Digite o juros do cupom:\n");
       scanf("%lf",&juros);
       jurosdiv = juros/100;
       vartempo = tempo*12;
       valorFuturo = valorInicial * pow(1 + jurosdiv, vartempo);
       if(tempo<=12)
       {
           impostos=valorInicial-valorFuturo*0.175;
           printf("O Valor do imposto em R$ %.2lf\n",impostos);
           printf("O Valor Total sera: R$ %.2lf\n",valorFuturo);
       }else if(tempo>=24)
       {
           impostos=valorInicial-valorFuturo*0.15;
           printf("O Valor do imposto em R$: %.2lf\n",impostos);
           printf("O Valor Total sera: R$ %.2lf\n",valorFuturo);
       }else{
           impostos=valorInicial-valorFuturo*0.15;
           printf("O Valor do imposto em R$: %.2lf\n",impostos);
           printf("O Valor Total sera: R$ %.2lf\n",valorFuturo);
       }
   }
   void calculadora()
   {
   }
   while(opcao!=3){
        scanf("d",&opcao);
    switch(opcao){
            case 1:
            calc();
            break;
            case 2:
            calc_rf();
            break;
            default:
            printf("Opcao Invalida");
            break;
   }
    printf("Digite a opcao\n 1-Calculadora de Juros\n 2- Calculadora de rendimento aplicao\n");
   }







}
