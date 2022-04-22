using GestioneEventi;

string nuovoTitoloEvento;
DateTime nuovaDataEvento;
int nuoviPostiTotali;


// Crea Funzione qui
Console.WriteLine("Inserisci il titolo dell'evento:");
nuovoTitoloEvento = Console.ReadLine();

Console.WriteLine("Inserisci la data dell'evento (gg/mm/yyyy):");
nuovaDataEvento = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Inserisci la capienza massima:");
nuoviPostiTotali = Convert.ToInt32(Console.ReadLine());

Evento nuovoEvento = new Evento(nuovoTitoloEvento, nuovaDataEvento, nuoviPostiTotali);

Console.WriteLine("Vuoi effettuare delle prenotazioni?");
if (Console.ReadLine().ToLower() == "si" )
{
    Console.WriteLine("Quante prenotazioni vuoi effettuare?");
    int nuovePrenotazioni = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < nuovePrenotazioni; i++)
    {
        nuovoEvento.Prenota();
    }

    // Must Become a function
    Console.WriteLine("Numero di posti prenotati:" + nuovoEvento.getPostiPrenotati());
    Console.WriteLine("Numero di posti disponibili: " + (nuovoEvento.getPostiTotali() - nuovoEvento.getPostiPrenotati()));

    bool vuoiDisdire = true;
    while (vuoiDisdire)
    {
        Console.WriteLine("Vuoi disdire dei posti? (si/no)");
        if (Console.ReadLine().ToLower() == "si")
        {
            Console.WriteLine("Indica il numero di posti da disdire: ");
            int nuoveDisdette = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nuoveDisdette; i++)
            {
                nuovoEvento.Disdici();
            }
            // Must Become a function
            Console.WriteLine("Numero di posti prenotati:" + nuovoEvento.getPostiPrenotati());
            Console.WriteLine("Numero di posti disponibili: " + (nuovoEvento.getPostiTotali() - nuovoEvento.getPostiPrenotati()));

        } else
        {
            vuoiDisdire = false;
            // Must Become a function
            Console.WriteLine("Numero di posti prenotati:" + nuovoEvento.getPostiPrenotati());
            Console.WriteLine("Numero di posti disponibili: " + (nuovoEvento.getPostiTotali() - nuovoEvento.getPostiPrenotati()));
        }
    }
    
}


/* 
    Una volta completata la classe ProgrammaEventi, usatela nel vostro programma principale 
Program.cs per creare un nuovo programma di Eventi che l’utente vuole organizzare, 
chiedendogli qual è il titolo del suo programma eventi. 
Chiedete poi al vostro utente quanti eventi vuole aggiungere, e fategli inserire ad uno ad uno 
tutti gli eventi necessari chiedendo man mano tutte le informazioni richieste all’utente. 
Attenzione: qui si gestite eventuali eccezioni lanciate dagli eventi creati, in questo caso il 
programma informa l’utente dell’errore e non aggiunge l’evento al programma eventi (o 
meglio alla lista di Eventi del programmaEventi), ma comunque chiederà in continuazione 
all’utente di inserire eventi fintanto che non raggiunge il numero di eventi specificato 
inizialmente dall’utente.
Una volta compilati tutti gli eventi:
1. Stampate il numero di eventi presenti nel vostro programma eventi
2. Stampate la lista di eventi inseriti nel vostro programma usando il metodo già fatto
3. Chiedere all’utente una data e stampate tutti gli eventi in quella data. Usate il metodo 
che vi restituisce una lista di eventi in una data dichiarata e create un metodo statico
che si occupa di stampare una lista di eventi che gli arriva. Passate dunque la lista di 
eventi in data al metodo statico, per poterla stampare.
4. Eliminate tutti gli eventi dal vostro programma.


*/

Console.WriteLine("Inserisci il nome del tuo programma Eventi: ");
string nuovoTitoloProgramma = Console.ReadLine();
ProgrammaEventi nuovoProgramma = new ProgrammaEventi(nuovoTitoloProgramma);

Console.WriteLine("Indica il numero di eventi da inserire: ");
int nuoviEventiProgramma = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < nuoviEventiProgramma; i++)
{
    //Crea Funzione qui
    Console.WriteLine($"Inserisci il nome del {i + 1}° evento: ");
    nuovoTitoloEvento = Console.ReadLine();
    Console.WriteLine("Inserisci la data dell'evento (gg/mm/yyyy): ");
    nuovaDataEvento = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Inserisci il numero di posti totali: ");
    nuoviPostiTotali = Convert.ToInt32(Console.ReadLine());

    Evento nuovoEventoProgramma = new Evento(nuovoTitoloEvento, nuovaDataEvento, nuoviPostiTotali); 
    nuovoProgramma.AddEvento(nuovoEventoProgramma);
}

Console.WriteLine($"Il numero di eventi nel programma è: {nuovoProgramma.getNumeroEventi()}");
Console.WriteLine(nuovoProgramma.InfoProgramma());

Console.WriteLine("Inserisci una data per sapere che eventi ci saranno (gg/mm/yyyy): ");
List<Evento> eventiConcomitanti = nuovoProgramma.getEventiConcomitanti(DateTime.Parse(Console.ReadLine()));
ProgrammaEventi.PrintLista(eventiConcomitanti);
nuovoProgramma.SvuotaLista();