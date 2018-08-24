#include <stdio.h>
#include <stdlib.h>

int main()
{
    int numero;
    int numeroMaximo;
    int numeroMinimo;
    float acumulador = 0;
    float promedio;
    int i;

    for (i =0 ; i<10; i++)
    {
        printf("Ingrese un numero:\n");
        scanf("%d", &numero);

        acumulador = acumulador + numero;
        //printf("valor i:%d", i);
        printf("acumulador:%f", acumulador);

        if(i==0)
        {
            numeroMaximo = numero;
            numeroMinimo = numero;
        } else if(numero > numeroMaximo)
            {
                numeroMaximo = numero;
            }else if (numero < numeroMinimo)
                {
                    numeroMinimo = numero;
                }
    }

    promedio = acumulador / i;
    printf("Numero Maximo: %d \n", numeroMaximo);
    printf("Numero Minimo: %d \n", numeroMinimo);
    printf("Promedio: %2.2f \n", promedio);

    //pongo un comentario.

    return 0;
}
