using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
  public class Prostokat
  {
    public int bokA;
    public int bokB;

    // Zmieniamy 'void' na 'int', usuwamy parametry i dodajemy 'return'
    public int Pole()
    {
      return bokA * bokB;
    }

    public int Obwod()
    {
      return bokA * 2 + bokB * 2;
    }
  }
}