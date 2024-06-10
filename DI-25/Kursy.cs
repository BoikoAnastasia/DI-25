public class Kursy
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Cost { get; set; }
    public string Description { get; set; }

    public Kursy(int ID, string Name, double Cost, string Description)
    {
        this.ID = ID;
        this.Name = Name;
        this.Cost = Cost;
        this.Description = Description;
    }
}