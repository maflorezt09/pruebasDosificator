//INVERTIR UN NUMERO ENTERO (int) DE TRES CIFRAS

int numero = 123;
int numeroInvertido = 0;

/* 
    Aplicando el modulo (numero % 10) Se extrae el ultimo digito del numero
    Ejemplo: 123 % 10 = 3, 12 % 10 = 2, 2 % 10 = 2
    Se multiplica por 10 el numeroInvertido para agregar un 0 al final (al inicialiazar esta en 0)
    Luego se le suma el digito para ubicarlo a la inversa
    numeroInvertido = (0*10) + 3
    Se divide entre 10 el numero para quitarle el ultimo digito 
*/

for(int i = 0; i < 3 ; i++){
    int digito = numero % 10;
    numeroInvertido = (numeroInvertido * 10) + digito;
    numero = numero/10;
}

Console.WriteLine(numeroInvertido);
