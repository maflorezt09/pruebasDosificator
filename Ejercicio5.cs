//FRASE (STRING) INVERTIDA USANDO UN CICLO WHILE

string frase = "Roma ni se conoce sin oro ni se conoce sin amor";
string fraseInvertida = "";

//Tomamos el tamaño de la frase -1 ya que recorreremos la frase como un arreglo
int contador = frase.Length-1;

//Comenzamos desde el tamaño total de la frase para tomar el ultimo caracter e ir retrocediendo
//Guardamos la nueva cadena en fraseInvertida 
while(contador >= 0){
    fraseInvertida = fraseInvertida + frase[contador];
    contador--;
}

Console.WriteLine(fraseInvertida);