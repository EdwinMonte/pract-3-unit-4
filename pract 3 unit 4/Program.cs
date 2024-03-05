
class Program
{
    static void Main(string[] args)
    {
        Circulo miCirculo = new Circulo();
        miCirculo.Radio = 5;
        double area = miCirculo.CalcularArea(); // Método implementado de la clase abstracta Figura

        Console.WriteLine($"El área del círculo es {area}.");
        Console.ReadKey();
    }
}
