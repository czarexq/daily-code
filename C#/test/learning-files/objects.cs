using System;
using ConsoleApp2;

namespace ConsoleApp2
{
  class Program
  {
    static void Main(string[] args)
    {
      Prostokat figura1 = new Prostokat();
      figura1.bokA = 5;
      figura1.bokB = 10;

      // Wywołujemy metodę i wyświetlamy jej wynik w konsoli
      Console.WriteLine("Pole wynosi: " + figura1.Pole());
      Console.WriteLine("Obwód wynosi: " + figura1.Obwod());
    }
  }
}