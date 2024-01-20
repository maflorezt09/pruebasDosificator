//COMPROBAR SI UN NÚMERO ES MÚLTIPLO DE OTRO

/* Para verificar si un numero X es un multiplo de otro numero Y
Realizamos modulo de X entre Y y si el resultado es 0 -> X es multiplo

33 es multiplo de 11?
33 % 11 = 0, el resto de la divison es 0 entonces 33 sí es multiplo de 11
-35 % -7 = 0, el resto de la division es 0 entonces -35 sí es multiplo de -7*/

int multiplo = 33;
int numero = 11;

if(multiplo % numero == 0){
    Console.WriteLine("EL NUMERO "+multiplo+" ES MULTIPLO DE "+numero);
}else{
    Console.WriteLine("EL NUMERO "+multiplo+" NO ES MULTIPLO DE "+numero);
}