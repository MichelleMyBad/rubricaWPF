using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

namespace Rubrica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brush background;
        public MainWindow() //costruttore di MainWindow
        {
            InitializeComponent(); //alloca tutte le risorse necessarie, costruisce tutta la grafica
            background = dgDati.Background;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) //fa tutto dopo che viene caricata la grafica
        {

            int idx = 0;

            try
            {
                const int MAX = 100;

                StreamReader fin = new StreamReader("Dati.csv");
                fin.ReadLine();

                Contatto[] contatti = new Contatto[MAX];

                while (!fin.EndOfStream)
                {
                    if (idx < MAX) // metto le parti del csv finchè ci stanno, se sono più di 100 non ci stanno più quindi devo smettere di inserirle se no va in errore
                    {
                        string riga = fin.ReadLine();
                        Contatto c = new Contatto(riga);
                        contatti[idx++] = c;
                    }
                    else { break; }
                }

                for (; idx < MAX; idx++) // creo i contatti vuoti se c'è ancora spazio
                {
                    Contatto c = new Contatto();
                    contatti[idx] = c;
                }

                dgDati.ItemsSource = contatti;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nono\n {ex.Message} alla riga numero {idx}");
            }
        }

        private void dgDati_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            Contatto c = e.Row.Item as Contatto;//as ti mette l'item in c solo se è un contatto
            if (c != null) {

                if (c.Numero==0) { 
                
                    e.Row.Background = Brushes.Red;

                }
                else
                {
                    e.Row.Background= background;
                }
            
            }
        }
    }
}
