using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class Veterinario
    {
    
    private string name;
    private  double salario;
    
    public Veterinario(string name, double salario)
    {
        this.name = name;
        this.salario = salario;
    }

    public void vacunar(Animales animal)
    {
        animal.Vaccinated = true;
        Console.WriteLine(animal.Nombre + "Fue vacunado");
    }

    public void trabajando(Animales animal)
    {
        Console.WriteLine("\n El veterinario revisa a el/la:  " + animal);
    }


}

