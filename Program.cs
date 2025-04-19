namespace Tarea_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.Arrancar();
            Moto moto = new Moto();
            moto.Frenar();
            

            Autobus autobus = new Autobus();
            autobus.MostrarDatos();
            autobus.Arrancar();
            autobus.Frenar();
            autobus.Carga();
            autobus.Arrancar();
            autobus.Frenar();
            autobus.Descarga();
            Console.WriteLine("Fin");
            
        }
    }
    class Vehiculo {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int año { get; set; }
        public int numeroSerie { get; set; }
        public void Arrancar() {
            Console.WriteLine("Estoy arrancando");
        }
        public void Detenerce()
        {
            Console.WriteLine("Me estoy deteniendo");
        }
        public void Acelerar()
        {
            Console.WriteLine("Estoy acelerando");
        }
        public void Frenar()
        {
            Console.WriteLine("Estoy frenando");
        }
        public void MostrarDatos(){
            
            }
    }
    class Autobus : Vehiculo
    {
        //capacidad de pasajeros, número de puertas, número de asientos
        public int c_pasajeros = 30;
        public int n_puertas = 2;
        public int n_asiento = 20;
        public int pasajeros;
        public void Carga()
        {
            string x;
            Console.WriteLine("Ingrese el numero de pasajeros que deseen subir: ");
            x = Console.ReadLine();
            pasajeros = int.Parse(x);
            while (c_pasajeros < pasajeros)
            {
                Console.WriteLine("Se exedio la capacidad de pasajeros");
                Console.WriteLine("Ingrese el numero de pasajeros que deseen subir: ");
                x = Console.ReadLine();
                pasajeros = int.Parse(x);
            }
            
        }
        public void Descarga()
        {
            string x;
            int bajan;
            Console.WriteLine("Ingrese el numero de pasajeros que deseen bajar: ");
            x = Console.ReadLine();
            bajan = int.Parse(x);
            while (pasajeros < bajan)
            {
                Console.WriteLine("No ahi tantos pasajeros");
                Console.WriteLine("Ingrese el numero de pasajeros que deseen bajar: ");
                x = Console.ReadLine();
                bajan = int.Parse(x);
            }
            while (pasajeros > bajan)
            {
                string opcion;
                pasajeros -= bajan;
                Console.WriteLine("Han bajado: " + bajan);
                Console.WriteLine("¿Desea bajar mas pasajeros? ");
                Console.WriteLine("Ingrese Si[S] o No[N]");
                opcion = Console.ReadLine();
                while (opcion == "S" || opcion == "s")
                {
                    Console.WriteLine("Ingrese el numero de pasajeros que deseen bajar: ");
                    x = Console.ReadLine();
                    bajan = int.Parse(x);
                    pasajeros -= bajan;
                    Console.WriteLine("Han bajado: " + bajan);
                    Console.WriteLine("¿Desea bajar mas pasajeros? ");
                    Console.WriteLine("Ingrese Si[S] o No[N]");
                    opcion = Console.ReadLine();
                    while (pasajeros < bajan)
                    {
                        Console.WriteLine("Ingrese el numero de pasajeros que deseen bajar: ");
                        x = Console.ReadLine();
                        bajan = int.Parse(x);
                        pasajeros -= bajan;
                        Console.WriteLine("Han bajado: " + bajan);
                        Console.WriteLine("¿Desea bajar mas pasajeros? ");
                        Console.WriteLine("Ingrese Si[S] o No[N]");
                        opcion = Console.ReadLine();
                        if (pasajeros == 0) {
                            Console.WriteLine("Han bajado todos los pasajeros");
                        }
                    }
                }
                if (opcion == "N" || opcion == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR DE OPCION");
                    Console.WriteLine("Reingrese la opcion");
                    Console.WriteLine("¿Desea bajar mas pasajeros? ");
                    Console.WriteLine("Ingrese Si[S] o No[N]");
                    opcion = Console.ReadLine();
                }
            }
        }
    
        public void MostrarDatos()
        {
            Auto auto = new Auto();
            auto.Marca = "Toyota";
            auto.año = 2023;
            auto.numeroSerie = 0610;
            Console.WriteLine($"El auto Marca {auto.Marca} del año {auto.año} y de numero de serie {auto.numeroSerie}");
            Moto moto = new Moto();
            moto.Marca = "Kawasaki";
            moto.año = 2016;
            moto.numeroSerie = 0800;
            Console.WriteLine($"La moto Marca {moto.Marca} del año {moto.año} y de numero de serie {moto.numeroSerie}");
        }
    }
        
    class Moto : Vehiculo {
        public void Caracteristicas_M(){
            Console.WriteLine("Motocicleta");
        }
    }
    class Auto : Vehiculo
    {
        public void Caracteristicas_C()
        {
            Console.WriteLine("Auto");
        }
    }
}
