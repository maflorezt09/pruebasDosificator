//Recorra los números del 1 al 100. Muestre en pantalla los números pares o divisibles entre 3

//Digitar la opcion para listar numeros pares o listar numeros divisibles entre 3
Console.Write("1. MOSTRAR NUMEROS PARES DEL 1 AL 100\n");
Console.Write("2. MOSTRAR NUMEROS DIVISIBLES ENTRE 3 DEL 1 AL 100\n");
Console.Write("DIGITE UN OPCION: ");

//Se crea la variable opc que contendra la opcion digitada por el usuario
int opc = Convert.ToInt32(Console.ReadLine());

switch (opc){
	case 1:
		Console.WriteLine("LOS NUMEROS PARES ENTRE EL 1 Y EL 100 SON:");
		modulo(2);
		break;
	case 2:
		Console.WriteLine("LOS NUMEROS DIVISIBLES ENTRE 3 DEL 1 Y EL 100 SON:");
		modulo(3);
		break;
	default:
		Console.WriteLine("Opcion no valida digite otra opcion");
		break;
}

void modulo(int numero){

	/* Funcion que realiza el modulo a los numeros del 1 al 100
	el modulo de un num1 entre un num2 dara el resto de la division (num1/num2)
	Ejemplo: 11%2 = 1, 10%2 = 0, 12%3=0 
	Si al realizar modulo de un numero entre 2 da 0 es porque es par
	si el modulo de un numero entre 3 da 0 es porque este divisible entre 3 o multiplo de 3 */

	for (int i = 1; i < 101; i++){
		if(i % numero == 0){
			Console.WriteLine(i);
		}
	}
}