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

            //Principio de sustitucion #1
            //Mamiferos animal = new Caballo("Veloz");
            Mamiferos persona = new Humano("Paco"); //Creamos una instancia llamada persona de tipo Mamifero

            //Principio de sustitucion #2
            Mamiferos animal = new Mamiferos("Veloz");
            Caballo Veloz = new Caballo("Veloz");
            animal = Veloz; //En una variable de tipo mmiferos almaceno una variable de tipo caballo (Caballo es siempre mamifero)

            //Principio de sustitucion #3
            //Object miAnimal = new Caballo("Veloz");
            //Object miPersona = new Humano("Juan");
            //Object miMamifero = new Mamiferos("Wally");

            Mamiferos[] almacenAnimales = new Mamiferos[3];
            almacenAnimales[0] = Melon;
            almacenAnimales[1] = Pepe;
            almacenAnimales[2] = Copito;

            almacenAnimales[1].getnombre();

            /*
             
            Melon.Galopar();
            Pepe.CuidarCrias();
            Pepe.Pensar();
            Copito.Trepar();

            Melon.getnombre();
            Pepe.getnombre();
            Copito.getnombre();
            */
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