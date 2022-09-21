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
Console.WriteLine("Intesa san paolo");

Bank Bank = new Bank();

public class Bank
{
    public string name { get; set; }

    List<Client> clientList = new List<Client>();

    List<Loan> loanList = new List<Loan>();

    public Bank()
    {
        clientList.Add(new Client(1, "John", "Doe", "12345678910", 1200));
        clientList.Add(new Client(2, "Mike", "Doe", "12345678910", 1400));
        clientList.Add(new Client(3, "Alex", "Doe", "12345678910", 1600));
        clientList.Add(new Client(4, "Smith", "Doe", "12345678910", 1800));

        foreach (var item in clientList)
        {
            Console.WriteLine("id: {0}, name: {1}, surname: {2}, cf: {3}, wage: {4}", item.id, item.name, item.surname, item.CF, item.wage);
        }

        loanList.Add(new Loan(1, "John Doe", 20000, 200, "22 agosto 2001", "22 agosto 2011"));
        loanList.Add(new Loan(1, "John Doe", 40000, 400, "22 agosto 2001", "22 agosto 2011"));
        loanList.Add(new Loan(1, "John Doe", 60000, 600, "22 agosto 2001", "22 agosto 2011"));
        loanList.Add(new Loan(1, "John Doe", 80000, 800, "22 agosto 2001", "22 agosto 2011"));

        foreach (var item in loanList)
        {
            Console.WriteLine("id: {0}, client name: {1}, money amount: {2}, mortgage payment: {3}, start date: {4}, end date: {5}", item.id, item.clientName, item.money, item.mortgage, item.startDate, item.endDate);
        }
    }
}
