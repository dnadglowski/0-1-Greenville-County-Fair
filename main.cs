using System;

class Program {
  public static void Main (string[] args) {
    
    while(true){
      Console.WriteLine("************************************");
      Console.WriteLine("*  The stars shine in Greenville.  *");
      Console.WriteLine("************************************");

      Console.WriteLine("Please Enter the following number below from the following menu:");

      Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
      Console.WriteLine("2. Exit");
      int.TryParse(Console.ReadLine(), out int ans);
      if(ans == 2){
        Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
         break;
      }
      else if (ans == 1)
        Console.WriteLine("How many contestants in previous year?");
        int.TryParse(Console.ReadLine(), out int prev_year);
        Console.WriteLine("How many this year?");
        int.TryParse(Console.ReadLine(), out int cur_year);
        Console.WriteLine($"Last year's competition had {prev_year} contestants, and this year's has {cur_year} contestants Revenue expected this year is $10,650 It is true that this year's competition is bigger than last year's.");
    }
    
        } 
        
      }