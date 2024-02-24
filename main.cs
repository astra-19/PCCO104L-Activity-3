using System;

class Program {
  public static void Main (string[] args) {

    while (true) {
      Console.WriteLine ("Enter a number: ");
      string num = Console.ReadLine();
      
      if (int.TryParse(num, out int n) && n >= 0) {
        if (n == 0) {
          Console.WriteLine("Closing Program...");
          break;
        }
        for (int i = 0; i < n; i++) {
          for (int j = 0; j < n - i - 1; j++  ) {
          Console.Write(" ");
        }
        for (int j = 0; j < 2 * i + 1; j++ ) {
          Console.Write("*");
          }
          Console.WriteLine();
          }
      }
      else {
        Console.WriteLine("Invalid Value: ");
      }
    }
  }
}
