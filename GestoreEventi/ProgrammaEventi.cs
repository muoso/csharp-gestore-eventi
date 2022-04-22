using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneEventi
{
    public class ProgrammaEventi
    {
        private string titoloProgramma;
        List<Evento> listaEventi;

        public ProgrammaEventi(string titoloProgramma)
        {
            this.titoloProgramma = titoloProgramma;
            listaEventi = new List<Evento>();
        }

        //aggiunge alla lista del programma eventi un Evento, passato come parametro al metodo
        public void AddEvento(Evento nuovoEvento)
        {
            listaEventi.Add(nuovoEvento);
        }

        //restituisce una lista di eventi con tutti gli eventi presenti in una certa data.
        public List<Evento> getEventiConcomitanti(DateTime data)
        {
            List<Evento> listaEventiConcomitanti = new List<Evento>();
            foreach (Evento evento in listaEventi)
            {
                if (evento.getData() == data)
                {
                    listaEventiConcomitanti.Add(evento);
                }
            }
            return listaEventiConcomitanti;
        }

        //Presa una lista di eventi, li stampa in Console.
        public static void PrintLista(List<Evento> listaEventi)
        {
            foreach (Evento evento in listaEventi)
            {
                Console.WriteLine(evento.ToString());
            }
        }

        //Restituisce quanti eventi sono presenti nel programma
        public int getNumeroEventi()
        {
            return this.listaEventi.Count;
        }

        //Svuota la lista di eventi
        public void SvuotaLista()
        {
            this.listaEventi.Clear();
        }


        /*
        un metodo che restituisce una stringa che mostra il titolo del programma e tutti gli
        eventi aggiunti alla lista. Come nell’esempio qui sotto:
        Nome programma evento:
        data1 - titolo1
        data2 - titolo2
        data3 - titolo3
        */
        public string InfoProgramma()
        {
            string infoProgramma = "Ecco il tuo programma eventi: "+ Environment.NewLine + this.titoloProgramma;
            foreach (Evento evento in this.listaEventi)
            {
                infoProgramma += (Environment.NewLine + evento.ToString());
            }
            return infoProgramma;
        }

    }
}


