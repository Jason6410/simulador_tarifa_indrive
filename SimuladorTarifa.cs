public class SimuladorTarifa
{
    public static void Main(string[] args)
    {
        Console.WriteLine("==================================================");
        Console.WriteLine("          Indrive - Simulador de Tarifa");
        Console.WriteLine("==================================================");

        //Entrada de datos
        Console.WriteLine("Nombre del Pasajero");
        string nombre = Console.ReadLine();
        
        Console.WriteLine("Ingrese distancia del viaje (KM)"); 
        double distancia = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Hora de Salida (0hrs - 23hrs)");
        int hora = int.Parse(Console.ReadLine());
        
        Console.WriteLine("\nTipo de Vehículo: ");
        Console.WriteLine(" 1. Económico");
        Console.WriteLine(" 2. Confort");
        Console.WriteLine(" 3. Premium");
        Console.WriteLine(" 4. Moto");
        Console.WriteLine("Ingrese la opción: ");
        int tipoVehiculo = int.Parse(Console.ReadLine());

        //Proceso - 01:29:13 del video para continuar

        //Salida

    }
}