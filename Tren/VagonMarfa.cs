using System;
using System.Collections.Generic;
using System.Text;

namespace Tren
{
    class VagonMarfa : Vagon
    {
        public VagonMarfa(TipMarfa tipMarfa, int cantitate) : base(10000, DateTime.Now.Year)
        {
        }
    }
    enum TipMarfa
    {
        Cereale, Carbune, Otel
    }
}
