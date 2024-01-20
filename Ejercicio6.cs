//INDICAR SI UN NUMERO ES PRIMO O NO LO ES
//Los números primos son aquellos que solo son divisibles entre ellos mismos y el 1
//Para comprobar si es primo se debe dividir entre la serie de numeros primos [2, 3, 5, 7, 11]
//Si todas los modulos o resto son diferentes a 0 entonces el numero es primo

int numero = 439;
int[] seriePrimos = [2, 3, 5, 7, 11];
bool resultado = true;

//Inicializamos con el resultado de que es primo
//Si es divisible entre algun numero de la serie no es primo
for(int i = 0; i < seriePrimos.Length - 1; i++){
    if(numero % seriePrimos[i] == 0){
        resultado = false;
    }
}

if(resultado){
    Console.WriteLine("EL NUMERO "+numero+" ES PRIMO");
}else{
    Console.WriteLine("EL NUMERO "+numero+" NO ES PRIMO");
}


