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

Console.WriteLine("Digita 1 per cercare un cliente\nDigita 2 per aggiungere un cliente\nDigita 3 per rimuovere un cliente\nDigita 4 per aggiungere un prestito\nDigita 5 per rimuovere un prestito");
int digit = Convert.ToInt32(Console.ReadLine());

switch (digit)
{
    case 1:
        Console.WriteLine("Cerca tra i nostri clienti");
        var search = myBank.ClientSearch(Console.ReadLine());
        break;

    case 2:
        Console.WriteLine("\nDigita il nome:");
        string newName = Console.ReadLine();
        Console.WriteLine("\nDigita il cognome:");
        string newSurname = Console.ReadLine();
        Console.WriteLine("\nDigita il codice fiscale:");
        string newCf = Console.ReadLine();
        Console.WriteLine("\nDigita lo stipendio:");
        int newWage = Console.Read();

        Client nuovoCliente = new Client(newName, newSurname, newCf, newWage);
        myBank.addClient(nuovoCliente);
        Console.WriteLine($"Riepilogo: {newName} {newSurname} {newCf} {newWage}");
        Console.WriteLine("Cliente registrato");
        break;

    case 3:
        //myBank.removeClient();
        break;

    case 4:
        Console.WriteLine("\nDigita l'id del cliente:");
        int newId = Console.Read();
        Console.WriteLine("\nDigita il nome del cliente:");
        string newClient = Console.ReadLine();
        Console.WriteLine("\nDigita i soldi da prestare:");
        int newMoney = Console.Read();
        Console.WriteLine("\nDigita il numero di rate:");
        int newMortgage = Console.Read();
        Console.WriteLine("\nDigita la data di inizio:");
        string newStartDate = Console.ReadLine();
        Console.WriteLine("\nDigita la data di fine:");
        string newEndDate = Console.ReadLine();

        Loan nuovoPrestito = new Loan(newId, newClient, newMoney, newMortgage, newStartDate, newEndDate);
        myBank.addLoan(nuovoPrestito);
        Console.WriteLine($"Riepilogo: {newClient} {newMoney} {newMortgage} {newStartDate} {newEndDate}");
        Console.WriteLine("Prestito registrato");
        break;

    case 5:
        //myBank.removeLoan();
        break;
}