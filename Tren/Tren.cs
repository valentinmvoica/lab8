using System;
using System.Collections.Generic;
using System.Text;

namespace Tren
{
    class Tren
    {
        private Locomotiva locomotiva;
        private List<Vagon> vagoane = new List<Vagon>();

        private string nume;

        public Tren(string nume, Locomotiva locomotiva)
        {
            this.nume = nume;
            this.locomotiva = locomotiva;
        }
        public void AdaugaVagon(Vagon vagon)
        {
            this.vagoane.Add(vagon);
        }

        public void PleacaDinGara() 
        {
            Console.WriteLine("Trenul va pleca");

            foreach (Vagon vagon in vagoane)
            {
                if (vagon is VagonPersoaneClasaI)
                {
                    VagonPersoaneClasaI dePersoaneI = vagon as VagonPersoaneClasaI;
                    dePersoaneI.InchideUsile();
                    dePersoaneI.PornesteAC();
                    continue;
                }
                if (vagon is VagonPersoane)
                {
                    VagonPersoane dePersoane = vagon as VagonPersoane;
                    dePersoane.InchideUsile();
                }
            }

            locomotiva.Porneste();
            Console.WriteLine("Trenul a plecat pleca");
        }

        public void Mergi() {
            Console.WriteLine("Mergeeeeee");
        }
        public void OpresteInGara() 
        {
            Console.WriteLine("Trenul va opri");

            locomotiva.Opreste();

            foreach(Vagon vagon in vagoane)
            {
                if (vagon is VagonPersoaneClasaI)
                {
                    VagonPersoaneClasaI dePersoaneI = vagon as VagonPersoaneClasaI;
                    dePersoaneI.DeschideUsile();
                    dePersoaneI.OpresteAC();
                    continue;
                }
                if (vagon is VagonPersoane)
                {
                    VagonPersoane dePersoane = vagon as VagonPersoane;
                    dePersoane.DeschideUsile();
                }                
            }

            Console.WriteLine("Trenul a oprit");
        }
    }
}

