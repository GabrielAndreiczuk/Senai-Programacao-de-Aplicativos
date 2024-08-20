#include<stdio.h>
#include<stdlib.h>

float informar_Valor(){
    float valor;
    printf("\nINFORME O VALOR DA TEMPERATURA: ");
    scanf("%f",&valor);
    return valor;
}

int main(){
int loop=0, opcao;
float valor, resultado;

do{
    system("cls");
    printf("------------------ CONVERTER TEMPERATURA ------------------\n");
    printf("\n[1] CELCIUS PARA FAHREINHEIT   [2] FAHREINHEIT PARA CELCIUS");
    printf("\n[3] CELCIUS PARA KEVIN         [4] KELVIN PARA CELCIUS");
    printf("\n[0] SAIR DO SISTEMA");
    printf("\n\nOPCAO ESCOLHIDA: ");
    scanf("%d",&opcao);
    switch(opcao){
        case 0:
        loop=1;
        break;
        case 1:
            valor = informar_Valor();
            resultado = (valor*1.8)+32;
            printf("\nRESULTADO: %.1f C = %.1f F\n\n",valor,resultado);
            system("pause");
        break;
        case 2:
            valor = informar_Valor();
            resultado = (valor-32)/1.8;
            printf("\nRESULTADO: %.1f F = %.1f C\n\n",valor,resultado);
            system("pause");
        break;
        case 3:
            valor = informar_Valor();
            resultado = valor + 273.15;
            printf("\nRESULTADO: %.1f C = %.2f K\n\n",valor,resultado);
            system("pause");
        break;
        case 4:
            valor = informar_Valor();
            resultado = valor - 273.15;
            printf("\nRESULTADO: %.2f K = %.1f C\n\n",valor,resultado);
            system("pause");
        break;
    }
}while (loop==0);

 printf("\n");
 system("pause");
 return 0;
}
