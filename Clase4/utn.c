#include <stdio_ext.h>
#include <stdlib.h>
#include "utn.h"

static int getInt(int* pResultado);

static int getFloat(float* pResultado);

int utn_getEntero(int* pEntero, int reintentos, char* msjInicial, char* msjFinal, int minimo, int maximo)
{
    int retorno = -1;
    int auxiliarValor;

    for(;reintentos > 0;reintentos--)
    {
        printf(msjInicial);
        if(getInt(&auxiliarValor) == 0)
        {
            if(auxiliarValor >= minimo && auxiliarValor < maximo)
            {
                *pEntero = auxiliarValor;
                retorno = 0;
                break;
            }
            else
            {
                printf(msjFinal);
            }
        }
        else
        {
            printf("El valor debe ser numerico \n");
            __fpurge(stdin);
        }
    }
    return retorno;
}

int utn_getDecimal(float* pDecimal, int reintentos, char* msjInicial, char* msjFinal, int minimo, int maximo)
{
    int retorno = -1;
    float auxiliarValor;

    for(;reintentos > 0;reintentos--)
    {
        printf(msjInicial);
        if(getFloat(&auxiliarValor) == 0)
        {
            if(auxiliarValor >= minimo && auxiliarValor < maximo)
            {
                *pDecimal = auxiliarValor;
                retorno = 0;
                break;
            }
            else
            {
                printf(msjFinal);
            }
        }
        else
        {
            printf("El valor debe ser decimal \n");
            __fpurge(stdin);
        }
    }
    return retorno;
}


static int getInt(int* pResultado)
{
     if (scanf("%d",pResultado)== 1)
     {
        return 0;
     }
     else
     {
        return -1;
     }
}

static int getFloat(float* pResultado)
{
     if (scanf("%f",pResultado)== 1)
     {
        return 0;
     }
     else
     {
        return -1;
     }
}





