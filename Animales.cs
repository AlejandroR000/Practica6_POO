using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class Animales
    {

    protected String nombre;
   protected int edad;
    protected bool vaccinated;

 

    public Animales(string nombre)
        {
            this.nombre = nombre;
        }

        public virtual void comer()
        {
            Console.WriteLine(nombre + " duerme");
        }

        public virtual void dormir()
        {
            Console.WriteLine(nombre + " come");
        }

    public string Nombre { get => nombre; set => nombre = value; }
    public int Edad { get => edad; set => edad = value; }
   public bool Vaccinated { get => vaccinated; set => vaccinated = value; }

}

