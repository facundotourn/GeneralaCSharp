using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generala2017
{
    class Dado
    {
        
        int numero;

        public Dado(Random rand)
        {
            this.reroll(rand);
        }

        public int getNumero()
        {
            return this.numero;
        }

        public void reroll(Random rand)
        {
            do
            {
                this.numero = Math.Abs(rand.Next() % 7);
            } while (this.numero == 0);
        }
    }
}
