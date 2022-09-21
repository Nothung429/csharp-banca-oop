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

        //foreach (var item in clientList)
        //{
        //    Console.WriteLine("name: {0}, surname: {1}, cf: {2}, wage: {3}", item.name, item.surname, item.CF, item.wage);
        //}

        loanList.Add(new Loan(1, "John Doe", 20000, 200, "22 agosto 2001", "22 agosto 2011"));
        loanList.Add(new Loan(1, "John Doe", 40000, 400, "22 agosto 2001", "22 agosto 2011"));
        loanList.Add(new Loan(1, "John Doe", 60000, 600, "22 agosto 2001", "22 agosto 2011"));
        loanList.Add(new Loan(1, "John Doe", 80000, 800, "22 agosto 2001", "22 agosto 2011"));

        //foreach (var item in loanList)
        //{
        //    Console.WriteLine("id: {0}, client name: {1}, money amount: {2}, mortgage payment: {3}, start date: {4}, end date: {5}", item.id, item.clientName, item.money, item.mortgage, item.startDate, item.endDate);
        //}
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
}