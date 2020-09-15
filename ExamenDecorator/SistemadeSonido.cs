using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenDecorator
{
    //esta clase es otro decorador para vehiculo
    public class SistemadeSonido: IDecoracion //se implementa la interfaz IDecoracion
    {
        //variable de referencia hacia quien decoramos
        private IDecoracion decoramosA;

        //la variable de referencia la pasamos al objeto que va a ser decorado
        public SistemadeSonido (IDecoracion decoracion)
        {
            decoramosA = decoracion;
        }

        //nos regresará una cadena con un mensaje del sistema de sonido más lo que se está decorando
        public override string ToString()
        {
            return "Radio FM \r\n" +decoramosA.ToString();
        }

        //se implementan los métodos de la interfaz IDecoracion
        public double Costo()
        {
            //se calcula el costo
            return decoramosA.Costo() + 120;
        }
        //se invoca al metodo Funciona y se agrega un mensaje
        public string Funciona()
        {
            return decoramosA.Funciona() + ", el radio está encendida";
        }
    }
}
