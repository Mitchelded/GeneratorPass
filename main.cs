using System;

class Program {
  public static void Main (string[] args) {
   String symbol1 ="qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890@#₽&_-()=%*:/!?+";
    String symbol2 ="qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890";
    Console.WriteLine("Lenght:");
    int x = int.Parse(Console.ReadLine());
    string[] Pass = new string[x];
    Random rand = new Random();

    Console.WriteLine("Без спец симлволов?");
    string otvet = Console.ReadLine();
    
    if (otvet == "да" || otvet== "д"  || otvet== "if" || otvet== "yes" || otvet == "ye" || otvet == "y")
    {
    for(int i=0; Pass.Length>i;i++)
      {
        int y=rand.Next(0,62);
        Console.Write(symbol2[y]);     
      }
    }
    else
    {
      int y=rand.Next(0,78);
        Console.Write(symbol1[y]);
    }
    Console.WriteLine();
    
    
  }
}