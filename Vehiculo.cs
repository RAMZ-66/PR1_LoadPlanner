using System;

namespace PR1_LoadPlanner
{
    class Program
    {
       
        static void Main(string[] args)
        {
            // [B] Barril: 70kg (2 espacios verticales)
            // [BC] Bolsa de chatarra: 20kg
            // [BP] Bolsa con plantas: 3kg (2 espacios verticales)
            // [C1] Caja ligera: 5kg
            // [C2] Caja pesada: 15kg
            // [C3] Caja vacía: 0.2kg
            // [S] Silla: 4kg (2 espacios verticales)
           
            Objeto objeto1 = new Objeto("Barril", "B", 70, CasillasOcupadas.dos, Orientacion.vertical);
            
            Objeto objeto2 = new Objeto("Bolsa de chatarra", "BC", 20, CasillasOcupadas.una, Orientacion.ninguna);
           
            Objeto objeto3 = new Objeto("Bolsa con plantas", "BP", 3, CasillasOcupadas.dos, Orientacion.vertical);
            
            Objeto objeto4 = new Objeto("Caja ligera", "C1", 5f, CasillasOcupadas.una, Orientacion.ninguna);
            
            Objeto objeto5 = new Objeto("Caja pesada", "C2", 15f, CasillasOcupadas.una, Orientacion.ninguna);
            
            Objeto objeto6 = new Objeto("Caja vacía", "C3", .2f, CasillasOcupadas.una, Orientacion.ninguna);
            
            Objeto objeto7 = new Objeto("Silla", "S", 4f, CasillasOcupadas.dos, Orientacion.vertical);

            Objeto casillaVacia = new Objeto ("Casilla Vacía", "x", 0,CasillasOcupadas.cero, Orientacion.ninguna);

            Objeto[,] camion = new Objeto[4,3] {{casillaVacia, objeto1, objeto1}, {objeto6, objeto7, objeto7}, {objeto4, objeto5, objeto2}, {casillaVacia, objeto3, objeto3}};

            if (camion[0,1].peso > camion[0,2].peso) 
            {
                Console.WriteLine(camion[0,2].nombre + " se está aplastando");
            }

            

            //For que muestra en la consola los objetos del array en forma de una cuadricula
            
            for(int i = 0; i < camion.Length; i++ )
            {
                if (i < 4)
                {
                    Console.Write(camion[i,0].abreviacion + " ");                   
                }

                else if (i < 8)
                {
                    if(i < 5)
                    {
                        Console.WriteLine("");
                    }
                    Console.Write(camion[i-4,1].abreviacion + " ");

                }

                else if (i < 12)
                {
                    if(i < 9)
                    {
                        Console.WriteLine("");
                    }
                    Console.Write(camion[i-8,2].abreviacion + " ");

                }

                             
            }    

            
           Console.WriteLine("");
           Console.WriteLine("");   

            //Cadena de if que indica si todo está bien acomodado
            
            if ((camion[0,1].peso > camion[0,0].peso) && (camion[0,2].peso >= camion[0,1].peso))
            {
                if ((camion[1,1].peso > camion[1,0].peso) && (camion[1,2].peso >= camion[1,1].peso))
                {
                    if ((camion[2,1].peso > camion[2,0].peso) && (camion[2,2].peso >= camion[2,1].peso))
                    {
                        if ((camion[3,1].peso > camion[3,0].peso) && (camion[3,2].peso >= camion[3,1].peso))
                        {
                            
                            Console.WriteLine("Acomodo correcto, nada se está aplastando");

                        }
                    }
                }
            }
                    
            //Cadena de if que verifica si algo se está aplastando
            
            if (camion[0,2].peso < camion[0,1].peso) 
            {
                Console.WriteLine(camion[0,2].nombre + " se está aplastando");
            
                if(camion[0,1].peso < camion[0,0].peso)
                {
                    Console.WriteLine(camion[0,1].nombre + " se está aplastando");
                }
            }
            
            if (camion[1,2].peso < camion[1,1].peso) 
            {
                Console.WriteLine(camion[1,2].nombre + " se está aplastando");

                if(camion[1,1].peso < camion[1,0].peso)
                {
                    Console.WriteLine(camion[1,1].nombre + " se está aplastando");
                }
            
            }
            
            if  (camion[2,2].peso < camion[2,1].peso)
            {
                Console.WriteLine(camion[2,2].nombre + " se está aplastando");
            
                if(camion[2,1].peso < camion[2,0].peso)
                {
                    Console.WriteLine(camion[2,1].nombre + " se está aplastando");
                }
            
            }

            if (camion[3,2].peso < camion[3,1].peso) 
            {
                Console.WriteLine(camion[3,2].nombre + " se está aplastando");
            
                if(camion[3,1].peso < camion[3,0].peso)
                {
                    Console.WriteLine(camion[3,1].nombre + " se está aplastando");
                }
            
            }       

        }


        

        
        
    }
}