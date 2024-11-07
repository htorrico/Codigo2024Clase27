using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Circulo : Forma
    {
        
        public override void Dibujar()
        {
            Console.WriteLine($"Dibujando un círculo {_color.Pintar()}.");
        }
    }
}
