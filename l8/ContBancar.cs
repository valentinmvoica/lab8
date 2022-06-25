using System;
using System.Collections.Generic;
using System.Text;

namespace l8
{
    class ContBancar
    {
        private TipCont tipCont;
        private decimal sold = 0;
        public ContBancar(TipCont tipCont)
        {
            this.tipCont = tipCont;
        }
        public void Depunere(decimal valoareDepusa)
        {
            this.sold += valoareDepusa;
        }
        public decimal ExtrageBani(decimal sumaExtrasa)
        {
            if(tipCont == TipCont.Investitii && !TermenAtins)
            {
             //   Console.WriteLine("Termenul de extragere nu a fost atins");
                return 0;
            }
            if (sumaExtrasa >= sold)
            {
                sold -= sumaExtrasa;
                return sumaExtrasa;
            }

            //Console.WriteLine("Fonduri insuficiente");
            return 0;
        }
        public void RecalculeazaSold(decimal dobanda)
        {
            if (tipCont == TipCont.Economii)
            {
                sold = sold + sold * dobanda / 100;
            }
        }
        public bool TermenAtins{ get; set; }
    }
}
