using Proyecto_parcial__POO.Encapsulamiento;
using Proyecto_parcial__POO.indexadores;
using Proyecto_parcial__POO.Minecraft;
using Proyecto_parcial__POO.polimorfimso;
using Proyecto_parcial__POO.Propiedades;



class Program
{
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("\nMenú Principal");
            Console.WriteLine("1. Ejecutar Minecraft()");
            Console.WriteLine("2. Ejecutar Polimorfismo()");
            Console.WriteLine("3. Ejecutar Indexadores()");
            Console.WriteLine("4. Ejecutar Propiedades ()");
            Console.WriteLine("0. Salir");

            Console.Write("Ingrese su opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Minecraft();
                    break;
                case 2:
                    Polimorfismo();
                    break;
                case 3:
                    indexadores();
                    break;
                case 4:
                    propiedades();
                    break; 
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

        } while (opcion != 0);
    }

    static void Minecraft()
    {
        BloqueAgua bloqueAgua = new BloqueAgua(15, 25, true, 1);
        bloqueAgua.Colocar();
        Console.WriteLine($"Profundidad del agua: {bloqueAgua.Profundidad}");

        bloqueAgua.Expandir();
        Console.WriteLine($"Profundidad del agua después de expandirse: {bloqueAgua.Profundidad}");

        Console.WriteLine("Presione cualquier tecla para volver al menú principal...");
        Console.ReadKey();
    }

    static void Polimorfismo()
    {
        BloquePuerta puerta = new BloquePuerta(10, 20,  "textura_de_puerta");

        puerta.Interactuar();

       
        BloqueHielo hielo = new BloqueHielo(30, 40, "Bloque_de_Hielo", "textura_de_hielo");

        hielo.Interactuar();

        Console.WriteLine("Presione cualquier tecla para volver al menú principal...");
        Console.ReadKey();
    }

    static void indexadores ()
    {
        // Creamos un inventario con capacidad para 5 elementos
        InventarioMinecraft inventario = new InventarioMinecraft(5);

        // Añadimos algunos elementos al inventario
        inventario[0] = "Espada de hierro";
        inventario[1] = "Pico de diamante";
        inventario[2] = "Hacha de madera";
        inventario[3] = "comida";

        // Accedemos a los elementos del inventario usando el indexador
        Console.WriteLine("Elementos del inventario:");
        for (int i = 0; i < 5; i++)
        {
            try
            {
                Console.WriteLine($"Slot {i + 1}: {inventario[i]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"Slot {i + 1}: Vacío");
            }
        }
    }
   
    static void propiedades ()
    {
        
        JugadorMinecraft jugador = new JugadorMinecraft();

        // Asignar valores a las propiedades
        jugador.Nombre = "Steve";
        jugador.NivelExperiencia = 15;
        jugador.Monedas = 100;

        // Acceder a los valores de las propiedades
        Console.WriteLine($"Nombre: {jugador.Nombre}");
        Console.WriteLine($"Nivel de Experiencia: {jugador.NivelExperiencia}");
        Console.WriteLine($"Monedas: {jugador.Monedas}");
    }
}

  