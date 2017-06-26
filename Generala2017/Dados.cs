using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generala2017
{
    class Dados
    {
        private Random rand = new Random();
        Dictionary<int, Dado> daditos = new Dictionary<int, Dado>();
        int tiros = 3;

        public Dados()
        {
            for(int i = 0; i < 5; i++)
            {
                Dado d = new Dado(rand);
                daditos[i] = d;
            }
        }

        public Dictionary<int, Dado> getDaditos()
        {
            return daditos;
        }

        public void tirarDados(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                daditos[nums[i]].reroll(rand);
            }
        }

        public void tirarDados(Boolean[] list)
        {
            for(int i = 0; i < list.Length; i++)
            {
                if(list[i] == false)
                {
                    this.daditos[i].reroll(rand);
                }
            }

            unTurnoMenos();
        }

        public void tirarDados()
        {
            for(int i = 0; i < 5; i++)
            {
                daditos[i].reroll(rand);
            }
        }

        public void unTurnoMenos()
        {
            this.tiros--;
        }

        public bool isGameOver()
        {
            if (this.tiros == 0)
            {
                return true;
            }
            else return !this.tirarOtra();
        }


        public bool tirarOtra()
        {
            return true;
        }

        public int getTiros()
        {
            return this.tiros;
        }

        public void setTiros()
        {
            this.tiros = 3;
        }
    }
}
