using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConNota.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public string menu()
        {
            
            Console.WriteLine("------------------");
            Console.WriteLine("Quieres volver a hacerlo");
            Console.WriteLine("------------------");
            Console.WriteLine("N");
            Console.WriteLine("S");
            Console.WriteLine("------------------");
            string opcion = Console.ReadLine();
           
            return opcion;
        }
    }
}
