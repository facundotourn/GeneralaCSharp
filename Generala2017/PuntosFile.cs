using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generala2017
{
    class PuntosFile
    {
        string[] lines;
        string path;
        FileStream fs;
        Dictionary<char, int> dicc = new Dictionary<char, int>()
        {
            { '1', 1 }, { '2', 2 }, { '3', 3 }, { '4', 4 }, { '5', 5 }, { '6', 6 },
            { 'E', 7 }, { 'F', 8 }, { 'P', 9 }, { 'G', 10 }, { 'D', 11 }
        };

        public PuntosFile(string path, int n_players)
        {
            this.path = path;
            fs = File.Open(this.path, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            Byte[] info;

            for (int i = 0; i < n_players; i++)
            {
                info = new UTF8Encoding(true).GetBytes("NombreApellido\t-\t-\t-\t-\t-\t-\t-\t-\t-\t-\t-\n");
                fs.Write(info, 0, info.Length);
            }

            // TENÉS QUE ARREGLAR EL TEMA DEL ARCHIVO, TITÁN
        }

        public string[] getPuntosPlayer(int index)
        {
           return lines[index - 1].Split('\t');
        }

        public void setPuntosPlayer(int index, string newP)
        {
            lines[index - 1] = newP;
        }

        public void actualizarPlayer(int num)
        {
            
        }

        public void actualizarFile()
        {
            
        }

        public void setCampoPlayer(char which, int player, int p)
        {
            int index;
            string[] camposPlayer = getPuntosPlayer(player);

            dicc.TryGetValue(which, out index);

            camposPlayer[index] = p.ToString();

            this.lines[player - 1] = String.Join("\t", camposPlayer);

            actualizarFile();
        }

        public Boolean canPlayerAnotar(char which, int player)
        {
            string[] campos = getPuntosPlayer(player);
            int index;

            dicc.TryGetValue(which, out index);

            return campos[index] == "-";
        }

    }
}
