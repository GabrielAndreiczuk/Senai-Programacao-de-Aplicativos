#include<stdio.h>
#include<stdlib.h>

float calc_resistencia(){//ESTA FUNÇÃO FAZ PARTE DA ATIVIDADE 1 E ATIVIDADE 2
    float V, I;
    printf("INFORME A TENSAO: ");
    scanf("%f",&V);
    printf("INFORME A CORRENTE: ");
    scanf("%f",&I);
    printf("RESISTENCIA: %.2f\n",V/I);
    return V/I;
}
float informar_Valor(){//ESTA FUNCAO FAZ PARTE DA ATIVIDADE 6
    float valor;
    printf("\nINFORME O VALOR DA TEMPERATURA: ");
    scanf("%f",&valor);
    return valor;
}

void atividade1(){//FUNCAO CORRESPONDENTE A ATIVIDADE 1
    float R1, R2, R3;//VARIAVEIS ATIVIDADE 1
    float RT;
    int opcao;
    do{
        system("cls");
        printf("CALCULO DE RESISTENCIA\n\n");
        printf("[1] RESITENCIA EM SERIE\n");
        printf("[2] RESISTENCIA EM PARALELO\n");
        printf("[0] VOLTAR AO MENU DE ATIVIDADES\n");
        printf("OPCAO ESCOLHIDA: ");
        scanf("%d",&opcao);

        switch(opcao){
            case 0:

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
}

void atividade2(){//FUNCAO CORRESPONDENTE A ATIVIDADE 2
    float R1, R2, R3, RT;
    float R[25];
    int opcao, resistencias;
    int i;
    do{
        system("cls");
        printf("CALCULO DE RESISTENCIA\n\n");
        printf("[1] RESISTENCIA EM SERIE\n");
        printf("[2] RESISTENCIA EM PARALELO\n");
        printf("[0] VOLTAR AO MENU DE ATIVIDADES\n");
        printf("OPCAO ESCOLHIDA: ");
        scanf("%d",&opcao);

        switch(opcao){
            case 0:

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
}

void atividade3(){//FUNCAO CORRESPONDENTE A ATIVIDADE 3
    float nota1,nota2,nota3,nota4,media;
    system("cls");
    printf("CALCULO DE MEDIA\n\n");
    printf("INFORME A PRIMEIRA NOTA: ");
    scanf("%f",&nota1);
    printf("INFORME A SEGUNDA NOTA: ");
    scanf("%f",&nota2);
    printf("INFORME A TERCEIRA NOTA: ");
    scanf("%f",&nota3);
    printf("INFORME A QUARTA NOTA: ");
    scanf("%f",&nota4);
    media = (nota1+nota2+nota3+nota4)/4;
    printf("MEDIA: %.1f",media);
    if(media>=7){
        printf("\nO ALUNO ESTA APROVADO!\n\n");
    }else{
        printf("\nO ALUNO ESTA REPROVADO!\n\n");
    }
    system("pause");
}

void atividade4(){//FUNCAO CORRESPONDENTE A ATIVIDADE 4
    float nota[25],media, soma=0;
    int qtd_notas, i;
    system("cls");
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
        printf("\nO ALUNO ESTA APROVADO!\n\n");
    }else{
        printf("\nO ALUNO ESTA REPROVADO!\n\n");
    }
    system("pause");
}

void atividade5(){//FUNCAO CORRESPONDENTE A ATIVIDADE 5
    float distancia,consumoG,consumoE,consumoD,
      precoG,precoE,precoD,
      tamanho,
      total_valor,total_consumo,total_tanques;
    int opcao;
    system("cls");
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
    printf("\nTANQUES UTILIZADOS ----- %.2f\n\n",total_tanques);
    system("pause");
}

void atividade6(){//FUNCAO CORRESPONDENTE A ATIVIDADE 6
    int opcao;
    float valor, resultado;
    do{
        system("cls");
        printf("------------------ CONVERTER TEMPERATURA ------------------\n");
        printf("\n[1] CELCIUS PARA FAHREINHEIT   [2] FAHREINHEIT PARA CELCIUS");
        printf("\n[3] CELCIUS PARA KEVIN         [4] KELVIN PARA CELCIUS");
        printf("\n[0] VOLTAR AO MENU DE ATIVIDADES");
        printf("\n\nOPCAO ESCOLHIDA: ");
        scanf("%d",&opcao);
        switch(opcao){
            case 0:

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
    }while (opcao!=0);
}

void atividade7(){//FUNCAO CORRESPONDENTE A ATIVIDADE 7
    float peso, altura, imc;
    system("cls");
    printf("---------- CALCULO DE IMC ----------\n");
    printf("INFORME SEU PESO: ");
    scanf("%f",&peso);
    printf("INFORME SUA ALTURA: ");
    scanf("%f",&altura);
    imc  = peso / pow(altura,2);
    printf("\nSEU IMC: %.2f",imc);
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
    printf("\n\n");
    system("pause");
}

void atividade8(){//FUNCAO CORRESPONDENTE A ATIVIDADE 8
    char nome[50];
    float preco;
    int opcao,parcelas;
    system("cls");
    printf("--------------------- FORMA DE PAGAMENTO ---------------------\n\n");
    fflush(stdin);
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
    printf("\n\n");
    system("pause");
}

int main(){

int opcao,seila,loop=0,contador=0;

do{
    menu:
    system("cls");
    printf("--------------------- MENU DE ATIVIDADES ---------------------\n");
    printf("\n[1] CALCULO DE 3 RESISTENCIAS  [2] CALCULO DE 'N' RESISTENCIAS");
    printf("\n[3] CALCULO DE MEDIA 4 NOTAS   [4] CALCULO DE MEDIA 'N' NOTAS ");
    printf("\n[5] CALCULO DE COMBUSTIVEL     [6] CALCULO DE TEMPERATURA");
    printf("\n[7] CALCULO DE IMC             [8] FORMA DE PAGAMENTO");
    printf("\n[0] SAIR DO SISTEMA");
    printf("\n\nOPCAO ESCOLHIDA: ");
    scanf("%d",&opcao);
    switch(opcao){
        case 0:
            loop=1;
            break;
        case 1:
            atividade1();
            break;
        case 2:
            atividade2();
            break;
        case 3:
            atividade3();
            break;
        case 4:
            atividade4();
            break;
        case 5:
            atividade5();
            break;
        case 6:
            atividade6();
            break;
        case 7:
            atividade7();
            break;
        case 8:
            atividade8();
            break;
    }
}while(loop==0);

printf("\n");
system("pause");
return 0;
}
