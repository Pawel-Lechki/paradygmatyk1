namespace Kolokwium1.model;

public class Zbiornik : Przesylka
{
    private double pojemnosc;
    private double gestosc;

    public Zbiornik(int id, string opis, double pojemnosc, double gestosc) : base(id, opis)
    {
        this.pojemnosc = pojemnosc;
        this.gestosc = gestosc;
    }

    public override double waga()
    {
        return base.waga() + this.pojemnosc * this.gestosc;
    }

    public override string info()
    {
        return base.info() + $", zbiornik o pojemoności {this.pojemnosc}, gęstość płytu {this.gestosc} kg/L";
    }
}