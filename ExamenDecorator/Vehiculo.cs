using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenDecorator
{
    //la clase vehículo será el objeto el cual debe implementar la interfaz IDecoración 
    //para poder realizar la decoración
    public class Vehiculo: IDecoracion
    {
        //atributos o propiedades de la clase vehículo
        private string modelo { get; set; }
        private string caracteristicas { get; set; }
        public double costo { get; set; }
        
        //constructor de la clase Vehiculo
        public Vehiculo(string pModelo, string pCaracteristica, double pCosto)
        {
            modelo = pModelo;
            caracteristicas = pCaracteristica;
            costo = pCosto;
        }

        //método Puertas
        public void Puertas (bool Estado) //variable de tipo bool para ver el estado de las puertas
        {
            if (Estado) //dependiendo del estado de las puertas se mostrará el mensaje
                Console.WriteLine("Las puertas se encuentran cerradas");
            else
                Console.WriteLine("Las puertas están abiertas");
        }

        //utilizamos el override ToString para llevar a cabo la impresión del estado de manera rápida
        public override string ToString()
        {
            return string.Format("Modelo {0}, {1} \r\n", modelo, caracteristicas);
        }

        //métodos que se implementan de la interfaz IDecoracion
        public double Costo() //el método Costo retornará el valor de la variable "costo"
        {
            return costo;
        }
        public string Funciona()//el método Funciona retornará una cadena con mensake "El motor está encendido"
        {
            return "El motor está encendido";
        }
    }
}

