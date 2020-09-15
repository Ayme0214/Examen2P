using System;

namespace ExamenDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //se crea el componente central llamado "IComponente" el cual va a permitir la decoración
            //creamos la variable "miVehiculo" y referenciamos la instancia de Vehiculo
            IDecoracion miVehiculo = new Vehiculo("KIA Sportage", "4 puertas", 25000); //colocamos las caracteristicas del vehiculo
            Console.WriteLine(miVehiculo);

            //usaremos un type cast para hacer uso de un método propio de la clase Vehiculo
            ((Vehiculo)miVehiculo).Puertas(true);//se puede invocar a 'Puertas' y darle un valor de true
           
            Console.WriteLine("********");

            //empezamos a decorar el vehiculo

            //decoraremos con el Nitrogeno
            //creamos una instancia de 'Nitrogeno' el cual tiene las caracteristicas extras que se adicionarán
            //y 'miVehiculo' es pasado como parámetro 
            miVehiculo = new Nitrogeno(miVehiculo);
            //se comprueba las adiciones de las caracteristicas de 'miVehiculo'
            //invocamos los métodos de acuerdo a lo señalado en la clase Nitrogeno
            Console.WriteLine("El costo será de: " +miVehiculo.Costo());
            Console.WriteLine(miVehiculo.Funciona());
            Console.WriteLine(miVehiculo);

            //para usar el método propio de la clase 'Nitrógeno' usaremos el type cast
            ((Nitrogeno)miVehiculo).UsandoNitrogeno(); //invocamos al método 'UsandoNitrogeno'
            Console.WriteLine("********");

            //ahora decoraremos con el SistemadeSonido
            miVehiculo = new SistemadeSonido(miVehiculo);
            Console.WriteLine("El costo es de: " + miVehiculo.Costo());
            Console.WriteLine(miVehiculo.Funciona());
            Console.WriteLine(miVehiculo);
            Console.WriteLine("********");

            //decoramos con la Suspension
            miVehiculo = new Suspension(miVehiculo);
            Console.WriteLine("El costo es de: " + miVehiculo.Costo());
            Console.WriteLine(miVehiculo.Funciona());
            Console.WriteLine(miVehiculo);
            Console.WriteLine("********");

            //decoramos con el SistemadeAire
            miVehiculo = new SistemadeAire(miVehiculo);
            Console.WriteLine("El costo es de: " + miVehiculo.Costo());
            Console.WriteLine(miVehiculo.Funciona());
            Console.WriteLine(miVehiculo);
            Console.WriteLine("********");

            Console.ReadKey();
        }
    }
}
