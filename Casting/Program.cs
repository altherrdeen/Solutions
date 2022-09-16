namespace Casting
{
  public class Program
  {
      static void Main(string[] args)
      {
          //Gewöhnlicher Cast
          int c = (int)2f;

          //Automatisch erstellte Casts
          int x = 5;
          float y = 10;
          y = x; //Kein Fehler, Implizit
          x = y; //Fehler, Implizit
          x = (int)y; //Explizit

          //Unmögliche Casts
          string data = "243";
          int converted = (int) data; //Fehler, casten ist hier unmöglich
          int converted2 = Convert.ToInt32(data); //Alternative
      }
  }
}
