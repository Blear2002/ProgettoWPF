using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoWPF
{
    class Articoli
    {
        int _codice;
        string _descrizione;
        double _prezzo;

        public int Codice
        {
            get
            {
                return _codice;
            }
            set { _codice = value; }
        }
        public string Descrizione
        {
            get
            {
                return _descrizione;
            }
            set { _descrizione = value; }
        }
        public double Prezzo
        {
            get
            {
                return _prezzo;
            }
            set { _prezzo = value; }
        }

        public Articoli(int codice, string descrizione, double prezzo)
        {
            _codice = codice;
            _descrizione = descrizione;
            _prezzo = prezzo;
        }
        
        public void Info()
        {
            Console.WriteLine("L'articolo " + _descrizione + " di codice " + _codice + " ha un prezzo di " + _prezzo + "$");
        }

        
    }
}
