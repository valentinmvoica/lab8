using System;
using System.Collections.Generic;
using System.Text;

namespace Tren
{
    class VagonPersoaneClasaI : VagonPersoane
    {
        public VagonPersoaneClasaI(int numarDeLocuri) : base(numarDeLocuri)
        {
        }
        public void PornesteAC()
        {
            Console.WriteLine("Am pornit clima");
        }
        public void OpresteAC()
        {
            Console.WriteLine("Am oprit clima");
        }
    }
}
