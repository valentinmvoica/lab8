using System;

namespace Tren
{
    class Program
    {
        static void Main(string[] args)
        {
            Tren tren1 = new Tren("ACC1433", new Locomotiva());
            tren1.AdaugaVagon(new VagonMarfa(TipMarfa.Cereale, 100));
            tren1.AdaugaVagon(new VagonPersoane(100));
            tren1.AdaugaVagon(new VagonPersoaneClasaI(100));
            tren1.AdaugaVagon(new VagonPersoane(100));

            tren1.PleacaDinGara();
            tren1.Mergi();
            tren1.OpresteInGara();

        }
    }
}
