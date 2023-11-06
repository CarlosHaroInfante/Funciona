using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConNota.Servicios
{
    internal class PedirImplementacion : PedirInterfaz
    {
        public int mes() 
            {
            int mesusu;
            Console.WriteLine("Dime un Mes");
            mesusu = Convert.ToInt32(Console.ReadLine());
            return mesusu;
             }
        
        public int anyo()
        {
            int año;
            Console.WriteLine("Dime un Año");
            año = Convert.ToInt32(Console.ReadLine());
            return año;
        }

    }
}
