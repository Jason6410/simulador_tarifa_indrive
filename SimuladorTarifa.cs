using System.Runtime.InteropServices.Marshalling;

public class SimuladorTarifa
{
    public static void Main(string[] args)
    {
        Console.WriteLine("==================================================");
        Console.WriteLine("          Indrive - Simulador de Tarifa");
        Console.WriteLine("==================================================");

        //DECLARACION DE VARIABLES
        string nombre, nombreVehiculo;
        double distancia, tarifaBase, costoKm, subtotal, descuento, tarifaFinal;
        int hora, tipoVehiculo;
        bool esHoraPico;

        //ENTRADA DE DATOS
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

        //Proceso
        switch (tipoVehiculo)
        {
            case 1: //ECONOMICO
                nombreVehiculo = "Económico";
                tarifaBase = 2.0;
                costoKm = 1.5;
                break;

            case 2: //CONFORT
                nombreVehiculo = "Confort";
                tarifaBase = 3.0;
                costoKm = 2.0;
                break;

            case 3: //PREMIUM
                nombreVehiculo = "Premium";
                tarifaBase = 5.0;
                costoKm = 3.0;
                break;

            case 4: //MOTO
                nombreVehiculo = "Moto";
                tarifaBase = 1.5;
                costoKm = 1.0;
                break;

            default:
                Console.WriteLine("\nOpción no válida. Fin del Programa");
                return;
        }

        //CALCULO DEL SUBTOTAL BASE
        subtotal = tarifaBase + (costoKm * distancia);

        //CONDICIONAL DE RECARGO POR HORA PICO
        if (hora >= 7 && hora <= 9 || hora >= 17 && hora <= 20)
        {
            esHoraPico = true;
            subtotal = subtotal * 1.30; //incremento del 30%
        }

        // DESCUENTO POR DISTANCIA LARGA (5%)
        if (distancia > 15)
        {
            descuento = subtotal * 0.05;
            subtotal = subtotal - descuento;
        }

        //TARIFA MINIMA Y REDONDEO
        tarifaBase = Math.Max(subtotal, 5.00);
        tarifaFinal = Math.Round(tarifaFinal, 2);

        //SALIDA - RESUMEN DEL VIAJE
        Console.WriteLine("\n==================================================");
        Console.WriteLine("                 RESUMEN DEL VIAJE");
        Console.WriteLine("====================================================");
        Console.WriteLine("Pasajero: " + nombre);
        Console.WriteLine("Vehículo: " + nombreVehiculo);
        Console.WriteLine("Distancia: " + distancia + "km");
        Console.WriteLine("Hora Pico: " + (esHoraPico?"Sí (+30%)":"No")); // inline if -> condicional "?" es verdad ":" es falso
        if (descuento > 0)
        {
            Console.WriteLine("Descuento: S/ " + Math.Round(descuento, 2));
        }
        else
        {
            Console.WriteLine("Descuento: No Aplica");
        }
        onsole.WriteLine("=====================================================");
        Console.WriteLine("          TARIFA FINAL: S/ " + tarifaFinal);
        Console.WriteLine("====================================================");
        Console.WriteLine("Pasajero: " + nombre);
    }
}