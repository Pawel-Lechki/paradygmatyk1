using Kolokwium1.model;

Paleta p1 = new Paleta(1, "lalki", 20, 10);
Zbiornik z1 = new Zbiornik(2, "płyn rozgrzewający", 100, 0.789);

Kurier k1 = new Kurier(500);

/*Console.WriteLine($"Wolne miejsce: {k1.wolneMiejsce()}");
Console.WriteLine($"Ladownosc: {k1.getLadownosc()}");*/
k1.zaladujPrzesylke(p1);
/*Console.WriteLine($"Ladownosc: {k1.getLadownosc()}");
Console.WriteLine($"Wolne miejsce: {k1.wolneMiejsce()}");*/
k1.zaladujPrzesylke(z1);

Console.WriteLine($"{k1.raportPrzysylkiDostarczone()}");

k1.dostarczPrzesylke(z1.getIdPrzesylki());

Console.WriteLine($"{k1.raportPrzysylkiDostarczone()}");
//Console.WriteLine(p1.info());

//Console.WriteLine(z1.info());

