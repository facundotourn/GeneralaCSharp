using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Generala2017
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dados miJuego = new Dados();
        private Boolean[] indexDados = { false, false, false, false, false };
        //private PuntosFile puntitos = new PuntosFile("puntos.txt", 1);
        private GamesCheck check = new GamesCheck();

        public MainWindow()
        {
            InitializeComponent();
        }

        // CLICK A BOTONES
        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            setEstadoStart();
        }

        private void tirarDadosButton_Click(object sender, RoutedEventArgs e)
        {
            miJuego.tirarDados(indexDados);
            Dictionary<int, Dado> dados = miJuego.getDaditos();

            setEstadoTirarDados();

            dado1TextBox.Clear();
            dado1TextBox.AppendText(dados[0].getNumero().ToString());
            dado2TextBox.Clear();
            dado2TextBox.AppendText(dados[1].getNumero().ToString());
            dado3TextBox.Clear();
            dado3TextBox.AppendText(dados[2].getNumero().ToString());
            dado4TextBox.Clear();
            dado4TextBox.AppendText(dados[3].getNumero().ToString());
            dado5TextBox.Clear();
            dado5TextBox.AppendText(dados[4].getNumero().ToString());

            if (miJuego.getTiros() != 0)
            {
                tirosTextBox.Text = "Queda/n " + miJuego.getTiros() + " tiro/s.";
            } else
            {
                tirosTextBox.Text = "No quedan tiros.";
                setEstadoAnotar();
            }

        }

        private void anotarButton_Click(object sender, RoutedEventArgs e)
        {
            setEstadoAnotar();
        }

        // ESTADOS
        private void setEstadoStart()
        {
            resetCheckBoxes();
            tirarDadosButton.IsEnabled = true;

            dado1TextBox.Text = "";
            dado2TextBox.Text = "";
            dado3TextBox.Text = "";
            dado4TextBox.Text = "";
            dado5TextBox.Text = "";

            unoButton.IsEnabled = false;
            dosButton.IsEnabled = false;
            tresButton.IsEnabled = false;
            cuatroButton.IsEnabled = false;
            cincoButton.IsEnabled = false;
            seisButton.IsEnabled = false;

            escaleraButton.IsEnabled = false;
            fullButton.IsEnabled = false;
            pokerButton.IsEnabled = false;
            generalaButton.IsEnabled = false;

            miJuego.setTiros();

            tirosTextBox.Text = "Quedan " + miJuego.getTiros() + " tiros.";

        }

        private void setEstadoTirarDados()
        {
            dado1CheckBox.IsEnabled = true;
            dado2CheckBox.IsEnabled = true;
            dado3CheckBox.IsEnabled = true;
            dado4CheckBox.IsEnabled = true;
            dado5CheckBox.IsEnabled = true;

            anotarButton.IsEnabled = true;

        }

        private void setEstadoAnotar()
        {
            tirarDadosButton.IsEnabled = false;
            anotarButton.IsEnabled = false;

            dado1CheckBox.IsEnabled = false;
            dado2CheckBox.IsEnabled = false;
            dado3CheckBox.IsEnabled = false;
            dado4CheckBox.IsEnabled = false;
            dado5CheckBox.IsEnabled = false;

            check = new GamesCheck(miJuego.getDaditos());

            unoButton.IsEnabled = check.getUno() != 0;
            dosButton.IsEnabled = check.getDos() != 0;
            tresButton.IsEnabled = check.getTres() != 0;
            cuatroButton.IsEnabled = check.getCuatro() != 0;
            cincoButton.IsEnabled = check.getCinco() != 0;
            seisButton.IsEnabled = check.getSeis() != 0;

            escaleraButton.IsEnabled = check.getEscalera();
            fullButton.IsEnabled = check.getFull();
            pokerButton.IsEnabled = check.getPoker();
            generalaButton.IsEnabled = check.getGenerala();

            

        }

        // OTROS MÉTODOS
        private void dado1CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (dado1CheckBox.IsChecked.Value)
            {
                this.indexDados[0] = true;
            }
            else
            {
                this.indexDados[0] = false;
            }
        }

        private void dado2CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (dado2CheckBox.IsChecked.Value)
            {
                this.indexDados[1] = true;
            }
            else
            {
                this.indexDados[1] = false;
            }
        }

        private void dado3CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            if (dado3CheckBox.IsChecked.Value)
            {
                this.indexDados[2] = true;
            }
            else
            {
                this.indexDados[2] = false;
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
           if (dado4CheckBox.IsChecked.Value)
            {
                this.indexDados[3] = true;
            }
            else
            {
                this.indexDados[3] = false;
            }
        }

        private void dado5CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (dado5CheckBox.IsChecked.Value)
            {
                this.indexDados[4] = true;
            }
            else
            {
                this.indexDados[4] = false;
            }
        }

        private void resetCheckBoxes()
        {
            dado1CheckBox.IsChecked = false;
            dado2CheckBox.IsChecked = false;
            dado3CheckBox.IsChecked = false;
            dado4CheckBox.IsChecked = false;
            dado5CheckBox.IsChecked = false;

            for(int i = 0; i < indexDados.Length; i++)
            {
                indexDados[i] = false;
            }
        }

        private void fullButton_Click(object sender, RoutedEventArgs e)
        {
            

            //puntitos.setCampoPlayer('F', 1, 30);
            //puntitos.actualizarFile();
        }
    }
}
