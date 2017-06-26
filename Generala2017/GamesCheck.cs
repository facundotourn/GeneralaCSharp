using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generala2017
{
    class GamesCheck
    {
        private Int32[] nums = new Int32[5];
        private Boolean generala;
        private Boolean poker;
        private Boolean full;
        private Boolean escalera;
        private Int32 uno;
        private Int32 dos;
        private Int32 tres;
        private Int32 cuatro;
        private Int32 cinco;
        private Int32 seis;

        public GamesCheck()
        {

        }

        public GamesCheck(Dictionary<int, Dado> dicc)
        {
            for(int i = 0; i < dicc.Count; i++)
            {
                this.nums[i] = dicc[i].getNumero();
            }

            Int32[] repe = contarRepetidos();

            this.generala = this.isGenerala(repe);
            this.poker = this.isPoker(repe);
            this.full = this.isFull(repe);
            this.escalera = this.isEscalera(repe);

            this.uno = repe[0] * 1;
            this.dos = repe[1] * 2;
            this.tres = repe[2] * 3;
            this.cuatro = repe[3] * 4;
            this.cinco = repe[4] * 5;
            this.seis = repe[5] * 6;

        }

        public Boolean getGenerala()
        {
            return this.generala;
        }

        public Boolean getPoker()
        {
            return this.poker;
        }

        public Boolean getFull()
        {
            return this.full;
        }

        public Boolean getEscalera()
        {
            return this.escalera;
        }

        public int getUno()
        {
            return this.uno;
        }

        public int getDos()
        {
            return this.dos;
        }

        public int getTres()
        {
            return this.tres;
        }

        public int getCuatro()
        {
            return this.cuatro;
        }

        public int getCinco()
        {
            return this.cinco;
        }

        public int getSeis()
        {
            return this.seis;
        }

        public Int32[] contarRepetidos()
        {
            Int32[] repetidos = { 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < nums.Length; i++)
            {
                switch (nums[i])
                {
                    case 1:
                        repetidos[0]++;
                        break;
                    case 2:
                        repetidos[1]++;
                        break;
                    case 3:
                        repetidos[2]++;
                        break;
                    case 4:
                        repetidos[3]++;
                        break;
                    case 5:
                        repetidos[4]++;
                        break;
                    case 6:
                        repetidos[5]++;
                        break;
                }
            }

            return repetidos;
        }

        private Boolean isGenerala(Int32[] r)
        {
            foreach(Int32 num in r)
            {
                if (num == 5)
                    return true;
            }

            return false;
        }

        private Boolean isPoker(Int32[] r)
        {
            foreach(Int32 num in r)
            {
                if(num == 4)
                {
                    return true;
                }
            }
            return false;
        }

        private Boolean isFull(Int32[] r)
        {
            for(int i = 0; i < r.Length; i++)
            {
                if(r[i] == 2)
                {
                    for(int j = i; j < r.Length; j++)
                    {
                        if(r[j] == 3)
                            return true;
                    }
                }

                if(r[i] == 3)
                {
                    for(int j = i; j < r.Length; j++)
                    {
                        if (r[j] == 2)
                            return true;
                    }
                }
            }

            return false;
        }

        private Boolean isEscalera(Int32[] r)
        {
            if (r[0] == 1 && r[1] == 1 && r[2] == 1 && r[3] == 1 && r[4] == 1)
            {
                return true;
            }

            if (r[1] == 1 && r[2] == 1 && r[3] == 1 && r[4] == 1 && r[5] == 1)
            {
                return true;
            }

            if (r[0] == 1 && r[5] == 1 && r[2] == 1 && r[3] == 1 && r[4] == 1)
            {
                return true;
            }

            return false;
        }
    }
}
