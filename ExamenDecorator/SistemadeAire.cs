using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenDecorator
{
    public class SistemadeAire : IDecoracion //implementa a la interfaz IDecoracion
    {
        //creamos la variable de referencia
        private IDecoracion decoramosA;

        //pasamos la variable al objeto que se está decorando
        public SistemadeAire(IDecoracion decoracion)
        {
            decoramosA = decoracion;
        }

        //usamos el override para retornar una cadena mensaje más lo que se está decorando
        public override string ToString()
        {
            return "Sistema de aire \r\n" + decoramosA.ToString();
        }

        //se implementan los métodos de IDecoracion
        public double Costo()
        {
            //calculamos el costo del objeto más el decorador
            return decoramosA.Costo() + 6000;
        }
        public string Funciona()
        {
            //se invoca al metodo funciona y agregamos mensaje
            return decoramosA.Funciona() + ", encendiendo sistema de aire del vehiculo";
        }
    }
}
