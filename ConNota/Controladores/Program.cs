namespace ConNota;

using ConNota.Servicios;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {

        PedirInterfaz pido = new PedirImplementacion();
        int mi2 = pido.mes();
        int mi3 = pido.anyo();

        NumInterfaz año = new NumImplementacion();
        bool años = año.numero1(mi3);

          
        
            if (años)
            {

                if (mi2 is 1 or 3 or 5 or 7 or 8 or 10 or 12)
                {

                    Console.WriteLine("Tiene 31 dias");
                }
                if (mi2 is 4 or 6 or 9 or 11)
                {

                    Console.WriteLine("Tiene 30 dias");
                }
                if (mi2 == 2)
                {

                    Console.WriteLine("tiene 29 dias");
                }
            }

            else
            {
                if (mi2 is 1 or 3 or 5 or 7 or 8 or 10 or 12)
                {

                    Console.WriteLine("Tiene 31 dias");
                }
                if (mi2 is 4 or 6 or 9 or 11)
                {

                    Console.WriteLine("Tiene 30 dias");
                    if (mi2 == 2)
                    {
                        Console.WriteLine("Tiene 28 dias");
                    }

                }
            }



            bool cerrarMenu = false;

            MenuInterfaz a = new MenuImplementacion();

            string opcion;


            opcion = a.menu();
            Console.WriteLine(opcion);

            while (!cerrarMenu)
            {
                if (opcion == "S") 
                { 
                Console.WriteLine("Deseas continuar");
                }

                else (opcion == "N")
                {
                    Console.WriteLine("Deseas Salir");
                    cerrarMenu = true;
                }
            }

           



          }

        
    }


    
    

