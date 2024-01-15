namespace Kolokwium1.model;

public class Paleta : Przesylka
{
    private int liczbaPudelek;
    private double masaPudelka;


    public Paleta(int id, string opis, int liczbaPudelek, double masaPudelka) : base(id, opis)
    {
        this.liczbaPudelek = liczbaPudelek;
        this.masaPudelka = masaPudelka;
    }

    public override double waga()
    {
        return base.waga() + this.liczbaPudelek * this.masaPudelka;
    }

    public override string info()
    {
        return base.info() + $", na palacie jest {this.liczbaPudelek} pudelek, o masie {this.masaPudelka} kg każde";
    }
}