namespace Kolokwium1.model;

public class Kurier
{
    private string id;
    private string opis;
    private bool dostarczona;
    private double masa;


    public Kurier(string id, string opis, bool dostarczona)
    {
        this.id = id;
        this.opis = opis;
        this.dostarczona = false;
    }

    public bool czyDostarczona()
    {
        return this.dostarczona;
    }

    public void dostarcz()
    {
        this.dostarczona = true;
    }

    public virtual double waga()
    {
        return this.masa;
    }

    public virtual string info()
    {
        return $"Przesyła id: {this.id}, zawiera: {this.opis}, waga: {this.waga()}";
    }
}