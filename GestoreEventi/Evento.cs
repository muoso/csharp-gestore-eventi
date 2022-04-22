using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneEventi
{
    public class Evento
    {
        internal string titoloEvento;
        internal DateTime dataEvento;
        private int postiTotali;
        private int postiPrenotati;

        
        public Evento(string titoloEvento, DateTime dataEvento, int postiTotali)
        {
            setTitolo(titoloEvento);
            setData(dataEvento);
            setPostiTotali(postiTotali);
            this.postiPrenotati = 0;
        }



        public void PrenotaPosti(int posti)
        {
            if(this.dataEvento<DateTime.Now)
            {
                throw new Exception("L'evento è gia avvenuto!");
            } else if (this.postiTotali < (this.postiPrenotati + posti))
            {
                throw new Exception("Non ci sono posti sufficienti!");
            }
            this.postiPrenotati += posti;
        }

        public void DisdiciPosti(int postiDisdetti)
        {
            if(this.dataEvento < DateTime.Now )
            {
                throw new Exception("L'evento è gia avvenuto!");
            } else if ((this.postiPrenotati - postiDisdetti) < 0)
            {
                throw new Exception("Non ci sono posti sufficienti da disdire");
            }
            this.postiPrenotati -= postiDisdetti;
        }

        public override string ToString()
        {
            string infoEvento = this.dataEvento.ToString("dd/MM/yyyy") + " - " + this.titoloEvento;
            return infoEvento;
        }




        public void setTitolo(string titolo) 
        { 
            if (titolo == "")
            {
                throw new ArgumentNullException("Non hai inserito il titolo! ");
            }
            this.titoloEvento = titolo; 
        }
        public string getTitolo() { return this.titoloEvento; }

        public void setData(DateTime data) 
        { 
            if (data < DateTime.Now)
            {
                throw new ArgumentOutOfRangeException("La data scelta è gia passata! ");
            }
            this.dataEvento = data; 
        }
        public DateTime getData() { return this.dataEvento; }

        private void setPostiTotali(int posti) 
        { 
            if(posti < 0)
            {
                throw new ArgumentOutOfRangeException("Hai inserito un numero negativo di posti! ");
            }
            this.postiTotali = posti; 
        }
        public int getPostiTotali() { return this.postiTotali; }

        private void setPostiPrenotati(int posti) { this.postiPrenotati = posti; }
        public int getPostiPrenotati() { return this.postiPrenotati; }

 
    }
}
