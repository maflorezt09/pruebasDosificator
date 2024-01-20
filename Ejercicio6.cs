//INDICAR SI UN NUMERO ES PRIMO O NO LO ES

/*
    Los números primos son aquellos que solo son divisibles entre ellos mismos y el 1
    Por lo que numeros negativos no pueden ser primos
    El 0 no se puede dividir entre si mismo por lo que no es primo, el 1 solo tiene un divisor entonces no es primo
    Para comprobar si es primo se debe dividir entre la serie de numeros primos [2, 3, 5, 7, 11]
    Si todas los modulos o resto son diferentes a 0 entonces el numero es primo
*/

int numero = 439;
int[] seriePrimos = [2, 3, 5, 7, 11];
bool resultado = true;
    //Inicializamos con el resultado de que sí es primo (true)

if(numero > 1){
    //Validamos que el numero sea mayor que 1

    //Validamos que el numero no se encuentre en la serie de primos para que en caso no se divida entre si
    //Si es divisible entre algun numero de la serie no es primo (false)
    for(int i = 0; i < seriePrimos.Length - 1; i++){
        if(numero != seriePrimos[i]){
            if(numero % seriePrimos[i] == 0){
                resultado = false;
            }
        }
    }

    if(resultado){
        Console.WriteLine("EL NUMERO "+numero+" ES PRIMO");
    }else{
        Console.WriteLine("EL NUMERO "+numero+" NO ES PRIMO");
    }

}else{
    Console.WriteLine("EL NUMERO "+numero+" NO ES PRIMO");
}
