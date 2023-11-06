using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConNota.Servicios
{
    internal class NumImplementacion : NumInterfaz
    {
        
            public bool numero1(int any)
            {
                bool Esbisiesto = true;
                Console.WriteLine(any);



                if (any % 4 == 0)
                {
                    Console.WriteLine("Es divisible entre 4");
                    
                    if (any % 100 == 0)
                    {
                        Console.WriteLine("Es Divisible entre 100");

                        if (any % 400 == 0)
                        {
                            Console.WriteLine("Es Divisible entre 400");

                        }
                    }

                }



                else
                {
                    Console.WriteLine("No es Bisiesto");
                    Esbisiesto = false;

                }

                return Esbisiesto;

            }
        }
}
