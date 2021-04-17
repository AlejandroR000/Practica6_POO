using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Gatos : Animales
    {

        public Gatos(string nombre) : base(nombre)
        {

        }

        public override void comer()
        {
            Console.WriteLine(nombre + " duerme en el sofa");
        }

        public override void dormir()
        {
            Console.WriteLine(nombre + " come comida enlatada ");
        }

    }

