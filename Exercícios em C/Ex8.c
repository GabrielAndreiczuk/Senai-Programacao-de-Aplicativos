#include<stdio.h>
#include<stdlib.h>

int main(){

char nome[50];
float preco;
int opcao,parcelas;

printf("--------------------- FORMA DE PAGAMENTO ---------------------\n\n");
printf("INFORME O NOME DO PRODUTO: ");
gets(nome);
printf("INFORME O PRECO DO PRODUTO: ");
scanf("%f",&preco);

printf("\n[1] A VISTA (DINHEIRO OU PIX) [2] A VISTA (CARTAO DE CREDITO)");
printf("\n[3] PARCELADO (2 VEZES)       [4] PARCELADO (3 OU MAIS VEZES)");
printf("\nOPCAO ESCOLHIDA: ");
scanf("%d",&opcao);

switch(opcao){
    case 1:
        preco=preco*0.85;
        printf("\nVALOR FINAL: R$%.2f",preco);
    break;
    case 2:
        preco=preco*0.9;
        printf("\nVALOR FINAL: R$%.2f",preco);
    break;
    case 3:
        printf("\nVALOR FINAL: R$%.2f",preco);
        printf("\n2X DE %.2f",preco/2);
    break;
    case 4:
        printf("\nDESEJA PARCELAR EM QUANTAS VEZES?: ");
        scanf("%d",&parcelas);
        if(parcelas>=3){
            preco=preco*1.1;
            printf("\nVALOR FINAL: R$%.2f",preco);
            printf("\n%dX DE %.2f",parcelas,preco/parcelas);
        }else{
            printf("\nERRO! ESCOLHA SOMENTE ACIMA DE 3 PARCELAS!");
        }
    break;
    default:
        printf("\nOPCAO INVALIDA!");
}


 printf("\n");
 system("pause");
 return 0;
}
