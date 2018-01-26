using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joku
{
    public class TestienAlustus
    {
        public int Summa(string luvut)
        {
            if (luvut.Equals(""))
            {
                return 0;
            }


            string[] numerot = luvut.Split(',');

            int vastaus = 0; // int.Parse(luvut);
            foreach (var numero in numerot)
            {
                vastaus += int.Parse(numero);
            }


            return vastaus;
        }
    }
}