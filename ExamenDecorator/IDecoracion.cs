using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenDecorator
{
    public interface IDecoracion //será la interfaz para la decoración
    {
        //creamos el método "Costo" y el método "Funciona"
        double Costo();
        string Funciona();
    }
}
