using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenDecorator
{
    public class Nitrogeno: IDecoracion //esta clase implementa ls interfaz IDecoracion
    {
        //variable de referencia hacia quien decoramos
        private IDecoracion decoramosA; //a través de esta variable nos comunicamos con el objeto que vamos a decorar
        
        //creamos el constructor y pasamos la variable anterior al objeto que se va a decorar
        public Nitrogeno (IDecoracion decoracion)
        {
            decoramosA = decoracion;
        }

        //regresa una cadena de un mensaje escrito por nosotros + el mensaje del objeto al que se esta deocrando
        public override string ToString()
        {
            return "Sistema de nitrogeno del vehiculo \r\n" + decoramosA.ToString();
        }

        //se implementan los métodos de la interfaz
        public double Costo()
        {
            //calculamos el costo 
            //el total del costo será "mi costo + el costo de lo que se está decorando"
            return decoramosA.Costo() + 3000;
        }
        public string Funciona()
        {//invocamos el metodo Funciona a quien se está decorando y se agrega un mensaje extra
            return decoramosA.Funciona() + ", el nitrógeno está listo";
        }

        //método adicional para indicar que se está usando el nitrógeno
        //esto se usará de manera independiente
        public void UsandoNitrogeno()
        {
            Console.WriteLine("Se está usando el nitrógeno");
        }
    }
}
