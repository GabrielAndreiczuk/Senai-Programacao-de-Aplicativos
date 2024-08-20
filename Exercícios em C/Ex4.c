#include<stdio.h>
#include<stdlib.h>

float nota[25],media, soma=0;
int qtd_notas, i;

int main(){
    printf("CALCULO DE MEDIA\n\n");
    printf("INFORME A QUANTIDADE DE NOTAS: ");
    scanf("%d",&qtd_notas);
    for(i=0;i<qtd_notas;i++){
        printf("INFORME A NOTA %d: ",i+1);
        scanf("%f",&nota[i]);
        soma = soma+nota[i];
    }
    system("cls");
    printf("CALCULO DE MEDIA\n");
    for(i=0;i<qtd_notas;i++){
        printf("\nNOTA %d: %.2f",i+1,nota[i]);
    }
    media=soma/qtd_notas;
    printf("\n\nMEDIA: %.2f",media);
    if(media>=7){
        printf("\nO ALUNO ESTA APROVADO!");
    }else{
        printf("\nO ALUNO ESTA REPROVADO!");
    }

    printf("\n");
    system("pause");
    return 0;
}
