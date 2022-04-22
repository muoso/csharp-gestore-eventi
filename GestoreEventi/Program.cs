using GestioneEventi;



Evento nuovoEvento = CreaEvento();

Console.Write("Vuoi effettuare delle prenotazioni? (si/no) ");
if (Console.ReadLine().ToLower() == "si" )
{
    Console.Write("Quante prenotazioni vuoi effettuare? ");
    int nuovePrenotazioni = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");

    for (int i = 0; i < nuovePrenotazioni; i++)
    {
        nuovoEvento.Prenota();
    }
    
    RiepilogoPosti(nuovoEvento);

    bool vuoiDisdire = true;
    while (vuoiDisdire)
    {
        Console.Write("Vuoi disdire dei posti? (si/no) ");
        if (Console.ReadLine().ToLower() == "si")
        {
            Console.Write("Indica il numero di posti da disdire: ");
            int nuoveDisdette = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nuoveDisdette; i++)
            {
                nuovoEvento.Disdici();
            }
            // Must Become a function
            RiepilogoPosti(nuovoEvento);

        } else
        {
            Console.WriteLine("Ok, va bene!" + Environment.NewLine);
            vuoiDisdire = false;
            RiepilogoPosti(nuovoEvento);
        }
    }
    
}


// Programma Eventi

Console.Write("Inserisci il nome del tuo programma Eventi: ");
string nuovoTitoloProgramma = Console.ReadLine();
ProgrammaEventi nuovoProgramma = new ProgrammaEventi(nuovoTitoloProgramma);

Console.Write("Indica il numero di eventi da inserire: ");
int nuoviEventiProgramma = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

for (int i = 0; i < nuoviEventiProgramma; i++)
{
    Evento nuovoEventoProgramma = CreaEvento();
    nuovoProgramma.AddEvento(nuovoEventoProgramma);
}

Console.WriteLine($"Il numero di eventi nel programma è: {nuovoProgramma.getNumeroEventi()}");
Console.WriteLine(nuovoProgramma.InfoProgramma());

Console.Write("Inserisci una data per sapere che eventi ci saranno (gg/mm/yyyy): ");
List<Evento> eventiConcomitanti = nuovoProgramma.getEventiConcomitanti(DateTime.Parse(Console.ReadLine()));
ProgrammaEventi.PrintLista(eventiConcomitanti);
nuovoProgramma.SvuotaLista();







static Evento CreaEvento()
{
    string nuovoTitoloEvento;
    DateTime nuovaDataEvento;
    int nuoviPostiTotali;


    Console.Write("Inserisci il titolo dell'evento: ");
    nuovoTitoloEvento = Console.ReadLine();

    Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
    nuovaDataEvento = DateTime.Parse(Console.ReadLine());

    Console.Write("Inserisci la capienza massima: ");
    nuoviPostiTotali = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("");

    Evento nuovoEvento = new Evento(nuovoTitoloEvento, nuovaDataEvento, nuoviPostiTotali);
    return nuovoEvento;
}

static void RiepilogoPosti(Evento nuovoEvento)
{
    Console.WriteLine("Numero di posti prenotati: " + nuovoEvento.getPostiPrenotati());
    Console.WriteLine("Numero di posti disponibili: " + (nuovoEvento.getPostiTotali() - nuovoEvento.getPostiPrenotati()));
    Console.WriteLine("");
}