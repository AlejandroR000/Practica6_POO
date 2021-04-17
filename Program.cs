using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            Animales caballo = new Animales("Caballo");
            Perros labrador = new Perros("Pelusa");
            Gatos negro = new Gatos("Bigotes");

            caballo.comer();
            caballo.dormir();

            Console.WriteLine();

            labrador.comer();
            labrador.dormir();

            Console.WriteLine();

            negro.comer();
            negro.dormir();

            Console.WriteLine();

            /////////////////////////////////
            //Ejercicio 2

            Animales Danes = new Perros("Lili");
            Console.WriteLine("-------------------");
            Danes.comer();
            Danes.dormir();

            Animales gatito = new Gatos("Grisi");
            gatito.comer();
            gatito.dormir();

            Console.WriteLine("\n-------------------------");
            ///Ejercicio 3
            Animales[] animalArray = new Animales[3];

            animalArray[0] = new Animales("Chispitas");
            animalArray[1] = new Perros("Pet");
            animalArray[2] = new Gatos("Mily");

            foreach(Animales Pets in animalArray)
            {
                Pets.comer();
                Pets.dormir();
                Console.WriteLine();
            }

            Console.WriteLine("\n>>-------------------------");
            ///Ejercicio 4
         /*
            foreach(Animales a in animalArray)
            {
                a.comer();
                if (a.GetType().IsInstanceOfType(animalArray))///No encontre la equivalencia de instanceof
                {
                    ((Perros)a).bark()
                }
            }

            */


            //Desafio



            Console.ReadLine();

        }
    }

