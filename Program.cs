using System;

class Program
{
    static void Main()
    {
      double runningTotal = 0;
      
      while (true)
      {
        Console.Write("Enter how many minutes you exercised: ");
        
        string entry = Console.ReadLine();
        if (entry.ToLower() == "quit")
        {
          break;
        }
        try
        {
                  double minutes = double.Parse(entry);
        if (minutes <= 0)
        {
         Console.WriteLine(minutes + " is not an acceptable value.")
           continue;
          
        }
        else if(minutes <= 10)
        {
                  Console.WriteLine("10 or less is better than nothing...")
           continue; 
          
        }
          Console.WriteLine("You've entered " + entry + " minutes.");

        runningTotal = runningTotal + minutes;
        Console.WriteLine("You've in total run for " + runningTotal + " minutes.");     
    }
}
