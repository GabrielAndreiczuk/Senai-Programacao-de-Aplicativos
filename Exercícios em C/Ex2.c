#include<stdio.h>
#include<stdlib.h>

float R1, R2, R3, RT;
float R[25];
int opcao, resistencias;
int i;

float calc_resistencia(){
    float V, I;
    printf("INFORME A TENSAO: ");
    scanf("%f",&V);
    printf("INFORME A CORRENTE: ");
    scanf("%f",&I);
    printf("RESISTENCIA: %.2f\n",V/I);
    return V/I;
}

int main(){

do{
    system("cls");
    printf("CALCULO DE RESISTENCIA\n\n");
    printf("[1] RESISTENCIA EM SERIE\n");
    printf("[2] RESISTENCIA EM PARALELO\n");
    printf("[0] SAIR\n");
    printf("OPCAO ESCOLHIDA: ");
    scanf("%d",&opcao);

    switch(opcao){
        case 0:
            printf("\n");
        break;
        case 1:
            system("cls");
            printf("MINIMO 1 MAXIMO 25!!!");
            printf("\nINSIRA O NUMERO DE RESISTENCIAS DO SISTEMA: ");
            scanf("%d",&resistencias);
            system("cls");
            printf("===== CASO NAO TENHA O VALOR DA RESISTENCIA DIGITE 0 =====\n\n");
            for(i=0;i<resistencias;i++){
                printf("INFORME O VALOR DA RESISTENCIA %d(R%d): ",i+1,i+1);
                scanf("%f",&R[i]);
                if(R[i]==0){
                    R[i]=calc_resistencia();
                }
            }
            RT = 0;
            system("cls");
            printf("CALCULO DE RESISTENCIA EM SERIE\n");
            for(i=0;i<resistencias;i++){
                printf("\nRESISTENCIA %d: %.2f",i+1,R[i]);
                RT = RT+R[i];
            }
            printf("\nVALOR DA RESISTENCIA TOTAL: %.2f\n",RT);
            system("pause");
        break;
        case 2:
            system("cls");
            printf("MINIMO 1 MAXIMO 25!!!");
            printf("\nINSIRA O NUMERO DE RESISTENCIAS DO SISTEMA: ");
            scanf("%d",&resistencias);
            system("cls");
            printf("===== CASO NAO TENHA O VALOR DA RESISTENCIA DIGITE 0 =====\n\n");
            for(i=0;i<resistencias;i++){
                printf("INFORME O VALOR DA RESISTENCIA %d(R%d): ",i+1,i+1);
                scanf("%f",&R[i]);
                if(R[i]==0){
                    R[i]=calc_resistencia();
                }
            }
            RT = 0;
            system("cls");
            printf("CALCULO DE RESISTENCIA EM PARALELO\n");
            float soma_res = 0;
            for(i=0;i<resistencias;i++){
                soma_res = soma_res + (1/R[i]);
            }
            RT = 1/soma_res;
            printf("\nVALOR DA RESISTENCIA TOTAL: %.2f\n",RT);
            system("pause");
        break;
        default:
        printf("\nOPCAO INVALIDA!\n");
        system("pause");
    }
}while(opcao!=0);


printf("\n\n");
system("pause");
return(0);
}
