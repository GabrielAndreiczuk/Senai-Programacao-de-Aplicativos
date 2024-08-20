#include<stdio.h>
#include<stdlib.h>

int main(){

float distancia,consumoG,consumoE,consumoD,
      precoG,precoE,precoD,
      tamanho,
      total_valor,total_consumo,total_tanques;
int opcao;

printf("------------ CALCULO DE COMBUSTIVEL ------------\n\n");
printf("INFORME A DISTANCIA PERCORRIDA EM KM: ");
scanf("%f",&distancia);
printf("INFORME O TAMANHO DO TANQUE DE COMBUSTIVEL EM L: ");
scanf("%f",&tamanho);
printf("INFORME O CONSUMO MEDIO EM KM/L DO VEICULO NA GASOLINA: ");
scanf("%f",&consumoG);
printf("INFORME O PRECO DA GASOLINA EM REAIS: ");
scanf("%f",&precoG);
printf("INFORME O CONSUMO MEDIO EM KM/L DO VEICULO NO ETANOL: ");
scanf("%f",&consumoE);
printf("INFORME O PRECO DO ETANOL EM REAIS: ");
scanf("%f",&precoE);
printf("INFORME O CONSUMO MEDIO EM KM/L DO VEICULO NO DIESEL: ");
scanf("%f",&consumoD);
printf("INFORME O PRECO DO DIESEL EM REAIS: ");
scanf("%f",&precoD);

system("cls");
total_valor = (distancia/consumoG)*precoG;
total_consumo = total_valor/precoG;
total_tanques = total_valor/(tamanho*precoG);
printf("------------ CALCULO DE COMBUSTIVEL ------------\n\n");
printf("COMBUSTIVEL: GASOLINA");
printf("\nVALOR TOTAL GASTO ------ R$%.2f",total_valor);
printf("\nCONSUMO R$/LITRO ------- %.2f",total_consumo);
printf("\nTANQUES UTILIZADOS ----- %.2f",total_tanques);
total_valor = (distancia/consumoE)*precoE;
total_consumo = total_valor/precoE;
total_tanques = total_valor/(tamanho*precoE);
printf("\n\n");
printf("COMBUSTIVEL: ETANOL");
printf("\nVALOR TOTAL GASTO ------ R$%.2f",total_valor);
printf("\nCONSUMO R$/LITRO ------- %.2f",total_consumo);
printf("\nTANQUES UTILIZADOS ----- %.2f",total_tanques);
total_valor = (distancia/consumoD)*precoD;
total_consumo = total_valor/precoD;
total_tanques = total_valor/(tamanho*precoD);
printf("\n\n");
printf("COMBUSTIVEL: DIESEL");
printf("\nVALOR TOTAL GASTO ------ R$%.2f",total_valor);
printf("\nCONSUMO R$/LITRO ------- %.2f",total_consumo);
printf("\nTANQUES UTILIZADOS ----- %.2f",total_tanques);


 printf("\n");
 system("pause");
 return 0;
}
