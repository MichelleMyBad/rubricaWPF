using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubrica
{
    internal class Contatto
    {
        private int _numero;
        private string _cognome;
        private string _telefono;

        public int Numero {
            get {
                return _numero;
            }
            set {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException();

                _numero = value; // value è il valore che gli passiamo, parola di c# che funziona in automatico  
               
            }
        }

        public string Nome { get; set; } // crea l'attributo senza esplicitarla
        public string Cognome { get => _cognome; set => _cognome = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }

        public Contatto(int numero, string nome, string cognome, string telefono)
        {
            Numero = numero;
            Nome = nome;
            Cognome = cognome;
            _telefono = telefono;
        }

        public Contatto() { }

        //Costruisce contatto partendo da una riga csv
        public Contatto (string riga)
        {
            string[] campi = riga.Split(';');


            if (campi.Length >= 4)
            {
                int pk=0;
                int.TryParse(campi[0], out pk);// prova a convertire la variabile e metterla in pk, se non è un intero mette 0  
                this.Numero = pk;
                this.Nome = campi[1];
                this.Cognome = campi[2];
                this.Telefono = campi[3];
            }


        }

    }
}
