using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneEventi
{
    public class Evento
    {
        private string titoloEvento;
        private DateTime dataEvento;
        private int postiTotali;
        private int postiPrenotati;

        
        public Evento(string titoloEvento, DateTime dataEvento, int postiTotali)
        {
            setTitolo(titoloEvento);
            setData(dataEvento);
            setPostiTotali(postiTotali);
            this.postiPrenotati = 0;
        }



        public void Prenota()
        {
            if(this.dataEvento<DateTime.Now || this.postiTotali == this.postiPrenotati)
            {
                throw new Exception();
            }
            this.postiPrenotati++;
        }

        public void Disdici()
        {
            if(this.dataEvento < DateTime.Now || this.postiPrenotati == 0)
            {
                throw new Exception();
            }
            this.postiPrenotati--;
        }

        public override string ToString()
        {
            string infoEvento = this.dataEvento.ToString("dd/MM/yyyy") + " - " + this.titoloEvento;
            return infoEvento;
        }




        public void setTitolo(string titolo) { this.titoloEvento = titolo; }
        public string getTitolo() { return this.titoloEvento; }

        public void setData(DateTime data) { this.dataEvento = data; }
        public DateTime getData() { return this.dataEvento; }

        private void setPostiTotali(int posti) { this.postiTotali = posti; }
        public int getPostiTotali() { return this.postiTotali; }

        private void setPostiPrenotati(int posti) { this.postiPrenotati = posti; }
        public int getPostiPrenotati() { return this.postiPrenotati; }

 
    }
}
