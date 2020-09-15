using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenDecorator
{
    public class Suspension: IDecoracion //implementa a la interfaz IDecoracion
    {
        //creamos la variable de referencia
        private IDecoracion decoramosA;

        //pasamos la variable al objeto que será decorado
        public Suspension(IDecoracion decoracion)
        {
            decoramosA = decoracion;
        }

        //usamos el override para retornar una cadena mensaje más lo que se está decorando
        public override string ToString()
        {
            return "La suspensión del vehiculo es de alto desempeño \r\n" + decoramosA.ToString();
        }

        //se implementan los métodos de IDecoracion
        public double Costo()
        {
            //calculamos el costo del objeto más el decorador
            return decoramosA.Costo() + 4000;
        }
        public string Funciona()
        {
            //se invoca al metodo funciona y agregamos mensaje
            return decoramosA.Funciona() + ", elevando suspensión del vehiculo";
        }
    }
}
