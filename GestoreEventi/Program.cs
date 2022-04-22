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


*/