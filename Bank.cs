public class Bank
{
    public string name { get; set; }

    List<Client> clientList = new List<Client>();

    List<Loan> loanList = new List<Loan>();

    public Bank(string name)
    {
        this.name = name;

        clientList.Add(new Client("John", "Doe", "12345678910", 1200));
        clientList.Add(new Client("Mike", "Poe", "12345678910", 1400));
        clientList.Add(new Client("Alex", "Foe", "12345678910", 1600));
        clientList.Add(new Client("Smith", "Goe", "12345678910", 1800));

        loanList.Add(new Loan(1, "John Doe", 20000, 200, "22 agosto 2001", "22 agosto 2011"));
        loanList.Add(new Loan(1, "John Doe", 40000, 400, "22 agosto 2001", "22 agosto 2011"));
        loanList.Add(new Loan(1, "John Doe", 60000, 600, "22 agosto 2001", "22 agosto 2011"));
        loanList.Add(new Loan(1, "John Doe", 80000, 800, "22 agosto 2001", "22 agosto 2011"));
    }
    public Client ClientSearch(string name)
    {
        foreach (Client data in this.clientList)
        {
            if (data.name.Contains(name))
            {
                Console.WriteLine($"cliente: {data.name}");
            }
        }
        return null;
    }

    public void addClient(Client client)
    {
        clientList.Add(client);
    }

    public void removeClient(Client client)
    {
        clientList.Remove(client);
    }

    public void addLoan(Loan loan)
    {
        loanList.Add(loan);
    }

    public void removeLoan(Loan loan)
    {
        loanList.Remove(loan);
    }
}