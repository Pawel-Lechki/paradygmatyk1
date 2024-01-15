using Kolokwium1.model;

namespace Testy;

[TestClass]
public class Test2
{
    [TestMethod]
    public void Test02()
    {
        // Arrenge
        Kurier k1 = new Kurier(1000);
        Paleta p1 = new Paleta(1, "lalki", 20, 10);
        Paleta p2 = new Paleta(2, "samochody", 10, 20);
        Zbiornik z1 = new Zbiornik(3, "płyn rozgrzewający", 100, 0.789);
        Zbiornik z2 = new Zbiornik(4, "woda", 100, 1);
        double wolneMiejsce1;
        double wolneMiejsce2;
        bool przesylkaDostarczona;

        // Act
        k1.zaladujPrzesylke(p1);
        k1.zaladujPrzesylke(p2);
        k1.zaladujPrzesylke(z1);
        k1.zaladujPrzesylke(z2);
        
        // Assert
        wolneMiejsce1 = k1.wolneMiejsce() + p2.waga();
        k1.dostarczPrzesylke(p2.getIdPrzesylki());
        Assert.AreEqual(wolneMiejsce1, k1.wolneMiejsce());
        wolneMiejsce2 = k1.wolneMiejsce() + z1.waga();
        k1.dostarczPrzesylke(z1.getIdPrzesylki());
        Assert.AreEqual(wolneMiejsce2, k1.wolneMiejsce());
        przesylkaDostarczona = k1.dostarczPrzesylke(10);
        Assert.IsFalse(przesylkaDostarczona);
    }
}