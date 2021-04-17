using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Perros : Animales
    {
        public Perros(string nombre) : base(nombre)
        {

        }

        public override void comer()
        {
            Console.WriteLine(nombre + " duerme en su casita");
        }

        public override void dormir()
        {
            Console.WriteLine(nombre + " Come croquetas");
        }

        public void bark()
        {
            Console.WriteLine(nombre + ": Woof");
        }

    }

