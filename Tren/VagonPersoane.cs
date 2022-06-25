using System;
using System.Collections.Generic;
using System.Text;

namespace Tren
{
    class VagonPersoane : Vagon
    {
        private int numarLocuri;
        public VagonPersoane(int numarLocuri) : base(50, 1974)
        {
            this.numarLocuri = numarLocuri;
        }
        public void InchideUsile()
        {
            Console.WriteLine("usile au fost inchise");
        }
        public void DeschideUsile()
        {
            Console.WriteLine("usile au fost deschise");
        }
    }
}
