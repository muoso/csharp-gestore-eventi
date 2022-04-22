using GestioneEventi;


bool exceptionLoop = true;


Evento nuovoEvento = CreaEvento();

Console.Write("Vuoi effettuare delle prenotazioni? (si/no) ");
if (Console.ReadLine().ToLower() == "si" )
{
    Console.Write("Quante prenotazioni vuoi effettuare? ");
    int nuovePrenotazioni = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");

    nuovoEvento.PrenotaPosti(nuovePrenotazioni);
    
    RiepilogoPosti(nuovoEvento);

    bool vuoiDisdire = true;
    while (vuoiDisdire)
    {
        Console.Write("Vuoi disdire dei posti? (si/no) ");
        if (Console.ReadLine().ToLower() == "si")
        {
            Console.Write("Indica il numero di posti da disdire: ");
            int nuoveDisdette = Convert.ToInt32(Console.ReadLine());
            
            nuovoEvento.DisdiciPosti(nuoveDisdette);
            
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
    Evento nuovoEventoProgramma = CreaCicloDiEventi(i);
    nuovoProgramma.AddEvento(nuovoEventoProgramma);
}


// Riepilogo
Console.WriteLine($"Il numero di eventi nel programma è: {nuovoProgramma.getNumeroEventi()}");
Console.WriteLine(nuovoProgramma.InfoProgramma());

Console.Write("Inserisci una data per sapere che eventi ci saranno (gg/mm/yyyy): ");
List<Evento> eventiConcomitanti = nuovoProgramma.getEventiConcomitanti(DateTime.Parse(Console.ReadLine()));
ProgrammaEventi.PrintLista(eventiConcomitanti);
nuovoProgramma.SvuotaLista();






Evento CreaEvento()
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

Evento CreaCicloDiEventi(int counter)
{
    string nuovoTitoloEvento;
    DateTime nuovaDataEvento;
    int nuoviPostiTotali;


    Console.Write($"Inserisci il titolo del {counter+1}° evento: ");
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