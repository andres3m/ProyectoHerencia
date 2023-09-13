using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProyectoHerencia
{
    public class Program
    {
        static void Main(string[] args)
        {
            Caballo Melon = new Caballo("Melon");
            Humano Pepe = new Humano("Pepe");
            Gorila Copito = new Gorila("Copito");


            Melon.Galopar();
            Pepe.CuidarCrias();
            Copito.Trepar();

            Melon.getnombre();
            Pepe.getnombre();
            Copito.getnombre();

        }
    }



    class Mamiferos : Object //Object es la superclase de object donde vienen las propiedades 
    {
        public Mamiferos(String nombre)  //Al crear nosotros la clase Mamiferos reemplazmos la clase base
        {
            nombreSerVivo = nombre;
        }
        public void Respirar()
        {
            Console.WriteLine("Puedo respirar");
        }
        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias");
        }

        public void getnombre()
        {
            Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
        }

        private String nombreSerVivo; 
    }



    class Caballo : Mamiferos
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        { 
        
        }

        public void Galopar()
        {
            Console.WriteLine("Galopo");
        }
    }



    class Humano : Mamiferos
    {
        public Humano(String nombreHumano): base(nombreHumano) { }
        public void Pensar()
        {
            Console.WriteLine("Pienso, luego existo");
        }
    }



    class Gorila : Mamiferos
    {
        public Gorila(String nombreGorila) : base(nombreGorila) { }
        public void Trepar()
        {
            Console.WriteLine("Trepo");
        }
    }
}