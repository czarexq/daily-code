using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
  abstract public class Pojazd
  {
    public string marka;
    public int rok_produkcji;

    public void Informacje()
    {
      Console.WriteLine($"Marka: {marka}, Rok produkcji: {rok_produkcji}");
    }
    public virtual void Dzwiek()
    {
      Console.WriteLine("");
    }
  }
}