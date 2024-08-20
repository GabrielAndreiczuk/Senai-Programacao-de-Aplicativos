#include<stdio.h>
#include<stdlib.h>

float R1, R2, R3;
float RT;
int opcao;

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
    printf("[1] RESSITENCIA EM SERIE\n");
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
            printf("===== CASO NAO TENHA O VALOR DA RESISTENCIA DIGITE 0 =====");
            printf("\n\nINFORME O VALOR DA RESISTENCIA 1(R1): ");
            scanf("%f",&R1);
            if(R1==0){
                R1=calc_resistencia();
            }
            printf("INFORME O VALOR DA RESISTENCIA 2(R2): ");
            scanf("%f",&R2);
            if(R2==0){
                R2=calc_resistencia();
            }
            printf("INFORME O VALOR DA RESISTENCIA 3(R3): ");
            scanf("%f",&R3);
            if(R3==0){
                R3=calc_resistencia();
            }
            RT=R1+R2+R3;
            printf("\nVALOR DA RESISTENCIA TOTAL: %.0f\n",RT);
            system("pause");
        break;
        case 2:
            system("cls");
            printf("===== CASO NAO TENHA O VALOR DA RESISTENCIA DIGITE 0 =====");
            printf("\n\nINFORME O VALOR DA RESISTENCIA 1(R1): ");
            scanf("%f",&R1);
            if(R1==0){
                R1=calc_resistencia();
            }
            printf("INFORME O VALOR DA RESISTENCIA 2(R2): ");
            scanf("%f",&R2);
            if(R2==0){
                R2=calc_resistencia();
            }
            printf("INFORME O VALOR DA RESISTENCIA 3(R3): ");
            scanf("%f",&R3);
            if(R3==0){
                R3=calc_resistencia();
            }
            RT = 1/(1/R1 + 1/R2 + 1/R3);
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
