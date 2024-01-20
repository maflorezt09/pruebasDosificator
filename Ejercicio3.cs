//CUAL ES EL NÚMERO INTERMEDIO (entre 3 numeros obtenidos por consola)

//Le pedimos al usuario que ingrese 3 numero que sean distintos
Console.Write("INGRESE 3 NUMEROS QUE SEAN DISTINTOS ENTRE SI\n");
Console.Write("INGRESE EL PRIMER NUMERO: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("INGRESE EL SEGUNDO NUMERO: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("INGRESE EL TERCER NUMERO: ");
int num3 = Convert.ToInt32(Console.ReadLine());

//Para validarlo por medio de condicionales se realizarian las siguientes validaciones

// a > b > c  --> Intermedio = b
// a > b < c
//     a > c  --> Intermedio = c
//     a < c  --> Intermedio = a
// a < b > c
//     a > c  --> Intermedio = a
//     a < c  --> Intermedio = c
// a < b < c  --> Intermedio = b

//Validamos que los numeros sean distintos entre si
if(num1!= num2 && num1!=num3 && num2!=num3){

    int intermedio = 0;

    if(num1 > num2){
        if(num2 > num3){
            intermedio = num2;
        }else if(num1 > num3){
            intermedio = num3;
        }else{
            intermedio = num1;
        }
    }else if(num2 > num3){
        if(num1 > num3){
            intermedio = num1;
        }else{
            intermedio = num3;
        }
    }else{
        intermedio = num2;
    }

    Console.WriteLine("EL NUMERO INTERMEDIO ES: "+intermedio);
    
}else{
    Console.WriteLine("LOS NUMEROS DEBEN SER DIFERENTES");
}