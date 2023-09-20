using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCompanion.Classes
{
    public class Utilitarios
    {
        Random rand = new Random();

        public int Rolar(int dado)
        {
            return rand.Next(1, dado);
        }

        public int Rolar(int dado, int mod)
        {
            return (rand.Next(1, dado) + mod);
        }

        public int RolarMultiplo(int dado, int quantidade)
        {
            var total = 0;
            for (int i = 0; i < quantidade; i++)
            {
                var aa = (Rolar(dado));
                total += aa;
            }
            return total;
        }

        public int RolarMultiplicado(int dado, int multiplicador)
        {
            return multiplicador * (Rolar(dado));
        }

    }
}
