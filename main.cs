using System;

class Program {
  public static void Main (string[] args) {
   String symbol ="qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890@#₽&_-()=%*:/!?+";
    int x = int.Parse(Console.ReadLine());
    string[] Pass = new string[x];
    Random rand = new Random();
    for(int i=0; Pass.Length>i;i++)
    {
      int y=rand.Next(0,78);
      Console.Write(symbol[y]);
      
    }
    
    
    
  }
}