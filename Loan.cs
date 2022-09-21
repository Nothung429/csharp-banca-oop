public class Loan
{
    public int id;
    public string? clientName;
    public int money;
    public int mortgage;
    public string? startDate;
    public string? endDate;

    public Loan(int id, string? clientName, int money, int mortgage, string? startDate, string? endDate)
    {
        this.id += 1;
        this.clientName = clientName;
        this.money = money;
        this.mortgage = mortgage;
        this.startDate = startDate;
        this.endDate = endDate;
    }
}