using System;

namespace Ejercicio3
{
    class Animal
    {
        public string especie;
        public int edad;
        public string genero;
        static void Main(string[] args)
        {
            Terrestre terrestre = new Terrestre();
            terrestre.T();
            terrestre.Camina();
            terrestre.Alimentar();
            terrestre.Ladra();
            terrestre.Pelea();
            terrestre.Reproducir();
            Acuaticos acuatico = new Acuaticos();
            acuatico.A();
            acuatico.Nadar();
            acuatico.Salta();
            acuatico.Alimentar();
            acuatico.Sonidos();
            acuatico.Pelea();
            acuatico.Reproducir();

        }
        public void Alimentar() {
            Console.WriteLine("Puede comer");
        }
        public void Reproducir()
        {
            Console.WriteLine("Se puede reproducir");
        }
        public void Sonidos()
        {
            Console.WriteLine("Puede hacer sonidos caracteristicos");
        }
        public void Pelea()
        {
            Console.WriteLine("Puede pelear");
        }

    }
    class Terrestre : Animal
    {
        public void T() {
            Console.WriteLine("Este es un animal terrestre");
            Mostrar();
        }
        public void Mostrar(){
            Terrestre terrestre = new Terrestre();
            terrestre.especie = "Caniche";
            terrestre.edad = 2;
            terrestre.genero = "Macho";
            Console.WriteLine($"Este animal es un {terrestre.especie} tiene {terrestre.edad} y es un {terrestre.genero}");
        }
        public void Ladra()
        {
            Console.WriteLine("Puede ladrar");
        }
        public void Camina()
        {
            Console.WriteLine("Puede caminar");
        }

    }
    class Acuaticos: Animal {
        public void A(){
            Console.WriteLine("Este es un animal acuatico");
            Ver();
        }
        public void Nadar() {
            Console.WriteLine("Puede nadar");
        }
        public void Salta() {
            Console.WriteLine("Puede saltar");
        }
        public void Ver() {
            Acuaticos acuatico = new Acuaticos();
            acuatico.especie = "Delfin";
            acuatico.edad = 15;
            acuatico.genero ="Hembra";
            Console.WriteLine($"Este animal es un {acuatico.especie} de {acuatico.edad} años de genero {acuatico.genero}");
        }
    }
}
