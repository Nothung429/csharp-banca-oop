//Sviluppare un’applicazione orientata agli oggetti per gestire i prestiti che una banca concede ai propri clienti.

//La banca è caratterizzata da
//    un nome
//    un insieme di clienti (una lista)
//    un insieme di prestiti concessi ai clienti (una lista)

//I clienti sono caratterizzati da
//    nome,
//    cognome,
//    codice fiscale
//    stipendio

//I prestiti sono caratterizzati da
//    ID
//    intestatario del prestito (il cliente),
//    un ammontare,
//    una rata,
//    una data inizio,
//    una data fine.

//Per la banca deve essere possibile:
//    aggiungere, modificare e ricercare un cliente.
//    aggiungere un prestito.
//    effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale
//    sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi.
//    sapere, dato il codice fiscale di un cliente, quante rate rimangono da pagare alla data odierna.

//Per i clienti e per i prestiti si vuole stampare un prospetto riassuntivo con tutti i dati che li caratterizzano in un formato di tipo stringa a piacere.

//Bonus:
//visualizzare per ogni cliente, la situazione dei suoi prestiti in formato tabellare.

Bank myBank = new Bank("Intesa san paolo");

Console.WriteLine($"benvenuto in {myBank.name}");

Console.WriteLine("Cerca tra i nostri clienti");
var search = myBank.ClientSearch(Console.ReadLine());

Console.WriteLine("Vuoi aggiungere un cliente? \nsi/no");
if (Console.ReadLine() == "si")
{
    Console.WriteLine("Digita il nome:\n");
    string newClientName = Console.ReadLine();
    Console.WriteLine("Digita il cognome:\n");
    string newClientSurname = Console.ReadLine();
    Console.WriteLine("Digita il codice fiscale:\n");
    string newClientCf = Console.ReadLine();
    Console.WriteLine("Digita lo stipendio:\n");
    int newClientWage = Console.Read();
    
    Client nuovo = new Client(newClientName, newClientSurname, newClientCf, newClientWage);
    myBank.addClient(nuovo);
    Console.WriteLine($"Riepilogo: {newClientName} {newClientSurname} {newClientCf} {newClientWage}");
    Console.WriteLine("Cliente registrato");
}

//Console.WriteLine("Vuoi rimuovere un cliente? \nsi/no");
//if (Console.ReadLine() == "si")
//{
//    myBank.removeClient();
//}