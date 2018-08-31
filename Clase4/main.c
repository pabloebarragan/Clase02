#include <stdio_ext.h>
#include <stdlib.h>
#include "utn.h"

int main()
{
    int entero;
    float decimal;

    if(utn_getEntero(&entero,3,"Ingrese una edad:\n","La edad esta fuera de rango\n",0,199) == 0)
    {
        printf("La valor ingresado es: %d",entero);
    }

    if(utn_getDecimal(&decimal,3,"Ingrese un decimal:\n","El decimal esta fuera de rango\n",0,199) == 0)
    {
        printf("El decimal ingresado es: %f",decimal);
    }

    return 0;
}
