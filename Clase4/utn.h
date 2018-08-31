#ifndef UTN_H_INCLUDED
#define UTN_H_INCLUDED

/**
    utn_getEntero : pide un entero al usaurio
    @param pEdad: puntero a edad
    @param reintentos: cantidad de reintentos
    @return = 0 OK, -1 ERROR
*/
int utn_getEntero(int* pEntero, int reintentos, char* msjInicial, char* msjFinal, int minimo, int maximo);

int utn_getDecimal(float* pDecimal, int reintentos, char* msjInicial, char* msjFinal, int minimo, int maximo);

#endif // UTN_H_INCLUDED
