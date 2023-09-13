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
            Caballo Melon = new Caballo();
            Humano Pepe = new Humano();
            Gorila Copito = new Gorila();



            Copito.Trepar();


        }
    }



    class Mamiferos : Object //Object es la superclase de object donde vienen las propiedades 
    {
        public void Respirar()
        {
            Console.WriteLine("Puedo respirar");
        }
        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias");
        }
    }



    class Caballo : Mamiferos
    {
        public void Galopar()
        {
            Console.WriteLine("Galopo");
        }
    }



    class Humano : Mamiferos
    {
        public void Pensar()
        {
            Console.WriteLine("Pienso, luego existo");
        }
    }



    class Gorila : Mamiferos
    {
        public void Trepar()
        {
            Console.WriteLine("Trepo");
        }
    }
}