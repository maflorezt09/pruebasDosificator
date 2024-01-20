/* El codigo valida los cambios en el valor de OUTPUT.CARGA_CEMENTO_1
Si se detectan cambios se realiza acciones en función del nuevo valor
La clase cValueChange ayuda a gestionar esos cambios esos cambios */
internal class cValueChange
{
    // Se define la clase cValueChange con dos propiedades publicas del tipo bool
    public bool ActualValue { get; set; }
    public bool LastValue { get; set; }

    //La clase posee el metodo isChange el cual compara ActualValue con LastValue
    //Si son diferentes actualiza lastValue con el valor de ActualValue y devuelve true de lo contrario false
    public bool isChange()
    {
        if (ActualValue != LastValue) 
        {
            LastValue = ActualValue;
            return true; 
        }
        return false;
    }
}
//Se crea una instancia de la clase cValueChange llamada _cargaCemento1VarStat
cValueChange _cargaCemento1VarStat = new cValueChange();

// CARGA CEMENTO 1 - SILO 1

//Se asigna el valor de OUTPUT.CARGA_CEMENTO_1 a la propieda ActualValue de _cargaCemento1VarStat
OUTPUT._cargaCemento1VarStat.ActualValue = OUTPUT.CARGA_CEMENTO_1;

//Se llama el metodo isChange() si hay cambios se ejecuta el if
//si es true llama a PLC.CARGA_CEMENTO_1(1), si es false llama a PLC.CARGA_CEMENTO_1(0).
if (OUTPUT._cargaCemento1VarStat.isChange())
{
   if (OUTPUT.CARGA_CEMENTO_1) PLC.CARGA_CEMENTO_1(1);
   else PLC.CARGA_CEMENTO_1(0);
}