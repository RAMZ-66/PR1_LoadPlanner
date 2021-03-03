using System;

namespace PR1_LoadPlanner
{

    enum CasillasOcupadas 
    {

        cero,
        una,
        dos,
        tres
    }

    enum Orientacion 
    {
        horizontal,
        vertical,
        ninguna
    }


    class Objeto
    {
      
        // Cada objeto que se agregará al vehículo tiene un nombre, una abreviación, un peso definido, y una cantidad de unidades de espacio que debe ocupar.

        public string nombre;
        public string abreviacion;
        public float peso;
        public CasillasOcupadas casillasOcupadas;
        public Orientacion orientacion;
            
    public Objeto(string nombre, string abreviacion, float peso, CasillasOcupadas casillasOcupadas, Orientacion orientacion)
    {
        this.nombre = nombre;

        this.abreviacion = abreviacion;

        this.peso = peso;

        this.casillasOcupadas = casillasOcupadas;

        this.orientacion = orientacion;
    }
         
    private string ObtenerNombreAMostrar()
    {
        string nombreAMostrar;
            if (this.nombre != null)
            {
                // Sí hay un nombre definido
                nombreAMostrar = this.nombre;
            }
            else
            {
                nombreAMostrar = "Objeto";
            }
            return nombreAMostrar;
        }

    }
   
}
