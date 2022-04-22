using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneEventi
{
    public class Conferenza : Evento
    {
        private string relatore;
        private double prezzo;

        public Conferenza(string titoloEvento, DateTime dataEvento, int postiTotali, string relatore, double prezzo) : base(titoloEvento, dataEvento, postiTotali)
        {
            setRelatore(relatore);
            setPrezzo(prezzo);
        }

        public override string ToString()
        {
            string infoEvento = base.dataEvento.ToString("dd/MM/yyyy") + " - " + base.titoloEvento + " - " + this.relatore + " - " + this.prezzo.ToString("0.00") + " euro";
            return infoEvento;
        }


        public void setRelatore(string relatore)
        {
            if (relatore == "")
            {
                throw new ArgumentNullException("Non hai inserito il relatore! ");
            }
            this.relatore = relatore;
        }
        public string getRelatore() { return this.relatore; }

        private void setPrezzo(double prezzo) { this.prezzo = prezzo; }
        public double getPrezzo() { return this.prezzo; }
    }
}
