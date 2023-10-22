// programa de distancia entre punto----------
using System;

class Punto
{
    public decimal x { get; set; }
    public decimal y { get; set; }

    public Punto(decimal x, decimal y)
    {
        this.x = x;
        this.y = y;
    }

    public double MedirDistancia(Punto puntoDestino)
    {
        double distancia = Math.Sqrt(Math.Pow((double)(puntoDestino.x - this.x), 4) + Math.Pow((double)(puntoDestino.y - this.y), 4));
        return distancia;
    }
}

class Program
{
    static void Main()
    {
        Punto puntoOrigen = new Punto(4.0M, 5.0M);
        Punto puntoDestino = new Punto(3.0M, 8.0M);

        double distancia = puntoOrigen.MedirDistancia(puntoDestino);

//total de distancias-----

        Console.WriteLine($"La distancia de los dos puntos es: {distancia}");
    }
}
