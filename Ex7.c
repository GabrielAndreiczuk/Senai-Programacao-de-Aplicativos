#include<stdio.h>
#include<stdlib.h>

int main(){

float peso, altura, imc;

printf("---------- CALCULO DE IMC ----------\n");
printf("INFORME SEU PESO: ");
scanf("%f",&peso);
printf("INFORME SUA ALTURA: ");
scanf("%f",&altura);
imc  = peso / pow(altura,2);
printf("\n\nSEU IMC: %.2f",imc);

if(imc>=40){
    printf("\nSITUACAO: OBESIDADE GRAU III(MORBIDA)");
}else if(imc>=35){
    printf("\nSITUACAO: OBESIDADE GRAU II(SEVERA)");
}else if(imc>=30){
    printf("\nSITUACAO: OBESIDADE GRAU I");
}else if(imc>=25){
    printf("\nLEVEMENTE ACIMA DO PESO");
}else if(imc>=18.6){
    printf("\nPESO IDEAL(PARABENS)");
}else{
    printf("\nABAIXO DO PESO");
}

 printf("\n");
 system("pause");
 return 0;
}
