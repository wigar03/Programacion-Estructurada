Console.Write("Ingrese la velocidad promedio en km/h: ");
double velocidad = Convert.ToDouble(Console.ReadLine());

// Distancia fija de 40 km
double distancia = 40;

// Cálculo del tiempo (tiempo = distancia / velocidad)
double tiempo = distancia / velocidad;

Console.WriteLine("El tiempo total del viaje es: " + tiempo + " horas");