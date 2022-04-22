using GestioneEventi;

/* 
- Memorizzare e tenere traccia di tutti gli eventi in futuro che ha programmato
- Poter gestire le prenotazioni e le disdette delle sue conferenze e tenere traccia
quindi dei posti prenotati e di quelli disponibili per un dato evento
- Poter gestire un intero programma di Eventi (ossia tenere traccia di tutti gli eventi 
che afferiscono ad serie di Conferenze)
*/


/* 
 Per prima cosa è necessario creare una classe Evento che abbia le seguenti proprietà:
● titolo
● data
● capienza massima dell’evento
● numero di posti prenotati
Aggiungere metodi getter e setter in modo che:
● titolo sia in lettura e in scrittura
● data sia in lettura e scrittura
● numero di posti totale sia solo in lettura
● numero di posti prenotati sia solo in lettura
ai setters inserire gli opportuni controlli in modo che la data non sia già passata, che il titolo 
non sia vuoto e che il numero di posti totali sia positivo. In caso contrario sollevare opportune
eccezioni.

Vanno inoltre implementati dei metodi public che svolgono le seguenti funzioni:
1. Prenota: aggiunge uno ai posti prenotati. Se l’evento è già passato o non ha posti
disponibili deve sollevare un’eccezione.
2. Disdici: riduce di uno i posti prenotati. Se l’evento è già passato o non ci sono
prenotazioni deve sollevare un’eccezione.
3. l’override del metodo ToString() in modo che venga restituita una 
stringa contenente: data formattata – titolo
Per formattare la data correttamente usate 
nomeVariabile.ToString("dd/MM/yyyy"); applicata alla vostra variabile 
DateTime.
Le eccezioni possono essere generiche (Exception) o usate quelle già messe a 
disposizione da C#, ma aggiungete un eventuale messaggio chiaro per 
comunicare che cosa è successo.


1. Nel vostro programma principale Program.cs, chiedete all’utente di inserire un 
nuovo evento con tutti i parametri richiesti dal costruttore.
2. Dopo che l’evento è stato istanziato, chiedete all’utente se e quante prenotazioni
vuole fare e provare ad effettuarle.
3. Stampare a video il numero di posti prenotati e quelli disponibili.
4. Ora chiedere all’utente fintanto che lo desidera, se e quanti posti vuole disdire. Ogni 
volta che disdice dei posti, stampare i posti residui e quelli prenotati.
Attenzione: In questa prima fase non è necessario dover gestire le eventuali eccezioni 
che potrebbero insorgere, eventualmente il programma si blocca se qualcosa va storto e 
che avete già previsto, piuttosto pensate bene alla logica del vostro programma principale 
e della vostra classe Evento pensando bene alle responsabilità dei metodi e alla visibilità 
di attributi e metodi.
Questo dovrebbe essere il risultato fino a qui


*/

Console.WriteLine("Inserisci un nuovo evento");

Console.WriteLine("Inserisci la data dell'evento:");
DateTime nuovaDataEvento = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il titolo dell'evento:");
string nuovoTitoloEvento = Console.ReadLine();

Console.WriteLine("Inserisci la capienza massima:");
int nuoviPostiTotali = Convert.ToInt32(Console.ReadLine());

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

    Console.WriteLine("Numero posti prenotati:" + nuovoEvento.getPostiPrenotati() + "| Numero posti disponibili: " + (nuovoEvento.getPostiTotali() - nuovoEvento.getPostiPrenotati()));
}