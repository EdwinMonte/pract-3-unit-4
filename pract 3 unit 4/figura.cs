using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

// Clase abstracta
public abstract class Figura
{
    // Método abstracto
    public abstract double CalcularArea();
}

// Clase que hereda de Figura e implementa el método abstracto
public class Circulo : Figura
{
    public double Radio { get; set; }

    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }
}

