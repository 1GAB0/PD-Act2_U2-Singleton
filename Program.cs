using System;

namespace Singleton_Pattern
{
    //
    // Clase Singleton
    public class Central_911
    {
        private static Central_911 _instance;
        private static readonly object _lock = new object();

        public string Central { get; private set; }

        private Central_911()
        {
            Central = "Central 911";
        }

        public static Central_911 Obtener_Instancia()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Central_911();
                    }
                }
            }
            return _instance;
        }

        public void ConectarLlamada(Operador operador, string tipoEmergencia)
        {
            Console.WriteLine("\nLlamada conectada con el operador " + operador.Nombre);
            operador.AtiendeEmergencia(tipoEmergencia);
        }
    }

    //
    // Clase Operador
    public class Operador
    {
        public int Id_Operador { get; set; }
        public string Nombre { get; set; }

        public Operador(int id, string nombre)
        {
            Id_Operador = id;
            Nombre = nombre;
        }

        public void AtiendeEmergencia(string tipoEmergencia)
        {
            Console.WriteLine($"Operador {Nombre} atendiendo emergencia de tipo: {tipoEmergencia}");

            switch (tipoEmergencia)
            {
                case "Intento de suicidio":
                    Console.WriteLine("Enviando unidades de apoyo y rescate");
                    break;
                case "Incendio":
                    Console.WriteLine("Enviando bomberos.");
                    break;
                case "Accidente":
                    Console.WriteLine("Enviado paramedicos y oficiales.");
                    break;
                case "Violeta":
                    Console.WriteLine("Enviando una patrulla.");
                    break;
                default:
                    Console.WriteLine("Tipo de emergencia no reconocido.");
                    break;
            }
        }
    }

    //
    // Cliente / Programa principal
    internal class Program
    {
        static void Main(string[] args)
        {
            Central_911 Llamada1 = Central_911.Obtener_Instancia();
            Central_911 Llamada2 = Central_911.Obtener_Instancia();
            Central_911 Llamada3 = Central_911.Obtener_Instancia();
            Central_911 Llamada4 = Central_911.Obtener_Instancia();
            Central_911 Llamada5 = Central_911.Obtener_Instancia();
            Central_911 Llamada6 = Central_911.Obtener_Instancia();

            Operador op1 = new Operador(1, "Laura");
            Operador op2 = new Operador(2, "Carlos");
            Operador op3 = new Operador(3, "Alex");
            Operador op4 = new Operador(4, "Alonso");
            Operador op5 = new Operador(5, "Marta");
            Operador op6 = new Operador(6, "Chris");

            Llamada1.ConectarLlamada(op1, "Incendio");
            Llamada2.ConectarLlamada(op2, "Violeta");
            Llamada1.ConectarLlamada(op1, "Accidente");
            Llamada2.ConectarLlamada(op2, "Intento de suicidio");
            Llamada3.ConectarLlamada(op3, "Incendio");
            Llamada4.ConectarLlamada(op4, "Accidente");
            Llamada5.ConectarLlamada(op5, "Violeta");
            Llamada6.ConectarLlamada(op6, "Asalto");

            Console.WriteLine("\nReferenceEquals: 1-2 " + ReferenceEquals(Llamada1, Llamada2));
            Console.WriteLine("ReferenceEquals: 1-3 " + ReferenceEquals(Llamada1, Llamada3));
            Console.WriteLine("ReferenceEquals: 1-4 " + ReferenceEquals(Llamada1, Llamada4));
            Console.WriteLine("ReferenceEquals: 1-5 " + ReferenceEquals(Llamada1, Llamada5));
            Console.WriteLine("ReferenceEquals: 1-6 " + ReferenceEquals(Llamada1, Llamada6));

            Console.ReadKey();
        }
    }
}
