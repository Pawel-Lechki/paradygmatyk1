namespace Kolokwium1.model;

public class Kurier
{
   private double ladownosc;
   private List<Przesylka> przesylki = new List<Przesylka>();

   public Kurier(double ladownosc)
   {
      this.ladownosc = ladownosc;
   }

   public double getLadownosc()
   {
      return this.ladownosc;
   }

   public void setLadownosc(double nowaLadownosc)
   {
      this.ladownosc = nowaLadownosc;
   }
   public double wolneMiejsce()
   {
      //double zajeteMiejsce = przesylki.Sum(przesylka => przesylka.waga());
      /*double zajete = 0;
      foreach (var przesylka in przesylki)
      {
         zajete += przesylka.waga();
      }
      Console.WriteLine($"zajęte: {zajete}");*/
      return this.ladownosc;
   }

   public bool zaladujPrzesylke(Przesylka przesylka)
   {
      if (this.wolneMiejsce() >= przesylka.waga())
      {
         przesylki.Add(przesylka);
         double updateLadownosc = wolneMiejsce() - przesylka.waga();
         setLadownosc(updateLadownosc);
         return true;
      }
      else
      {
         return false;
      }
   }

   public void dostarczPrzesylke(int idPrzesylki)
   {
      Przesylka przesylka = przesylki.Find(przesylka => przesylka.getIdPrzesylki() == idPrzesylki);
      przesylka.dostarcz();
      double zwolnioneMiejsce = getLadownosc() + przesylka.waga();
      setLadownosc(zwolnioneMiejsce);
   }

   public string raportPrzysylkiDostarczone()
   {
      string raport = "Raport\n";
      foreach (var przesylka in przesylki)
      {
         raport += $"{przesylka.info()} dostarczono: {przesylka.czyDostarczona()}\n";
      }

      raport += $"Pozostało ładowności: {this.wolneMiejsce()}\n";
      
      return raport;
   }
}