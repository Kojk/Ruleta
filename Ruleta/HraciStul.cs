using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruleta
{
    class HraciStul
    {
        public HraciPole[] HraciPolicka = new HraciPole[37];
        public HraciStul()    // konstruktor        
        {
            Barva[] rozmistneniBarev = new Barva[37] { Barva.zelena, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena, Barva.cerna, Barva.cervena };                        
            for (int i = 0; i< rozmistneniBarev.Length; i++)  //naplnenie policok
            {
                HraciPolicka[i].Barva = rozmistneniBarev[i];
                HraciPolicka[i].Cislo = i;
                HraciPolicka[i].Rada = vratRadu(i);
                HraciPolicka[i].Lichost = vratLichost(i);
            }
        }        
        private Lichost vratLichost(int cislo)
        {
            if (cislo == 0) return Lichost.zadna;
            if (cislo % 2 == 0) return Lichost.suda;
            return Lichost.licha;
        }
        private Rada vratRadu(int cislo)
        {
            if (cislo == 0) return Rada.zadna;
            if (cislo == 1 || cislo - 1 % 3 == 0) return Rada.prva;
            if (cislo == 2 || cislo - 2 % 3 == 0) return Rada.druha;
            return Rada.tretia;

        }
    }
}
