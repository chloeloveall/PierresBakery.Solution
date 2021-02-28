using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      string title = @"
      __       __            __                                                      __                                                    
      /  |  _  /  |          /  |                                                    /  |                                                   
      $$ | / \ $$ |  ______  $$ |  _______   ______   _____  ____    ______         _$$ |_     ______                                       
      $$ |/$  \$$ | /      \ $$ | /       | /      \ /     \/    \  /      \       / $$   |   /      \                                      
      $$ /$$$  $$ |/$$$$$$  |$$ |/$$$$$$$/ /$$$$$$  |$$$$$$ $$$$  |/$$$$$$  |      $$$$$$/   /$$$$$$  |                                     
      $$ $$/$$ $$ |$$    $$ |$$ |$$ |      $$ |  $$ |$$ | $$ | $$ |$$    $$ |        $$ | __ $$ |  $$ |                                     
      $$$$/  $$$$ |$$$$$$$$/ $$ |$$ \_____ $$ \__$$ |$$ | $$ | $$ |$$$$$$$$/         $$ |/  |$$ \__$$ |                                     
      $$$/    $$$ |$$       |$$ |$$       |$$    $$/ $$ | $$ | $$ |$$       |        $$  $$/ $$    $$/                                      
      $$/      $$/  $$$$$$$/ $$/  $$$$$$$/  $$$$$$/  $$/  $$/  $$/  $$$$$$$/          $$$$/   $$$$$$/                                       
                                                                                                                                            
                                                                                                                                            
                                                                                                                                            
      _______   __                                         __               _______             __                                      __ 
      /       \ /  |                                       /  |             /       \           /  |                                    /  |
      $$$$$$$  |$$/   ______    ______    ______    ______ $$/_______       $$$$$$$  |  ______  $$ |   __   ______    ______   __    __ $$ |
      $$ |__$$ |/  | /      \  /      \  /      \  /      \$//       |      $$ |__$$ | /      \ $$ |  /  | /      \  /      \ /  |  /  |$$ |
      $$    $$/ $$ |/$$$$$$  |/$$$$$$  |/$$$$$$  |/$$$$$$  |/$$$$$$$/       $$    $$<  $$$$$$  |$$ |_/$$/ /$$$$$$  |/$$$$$$  |$$ |  $$ |$$ |
      $$$$$$$/  $$ |$$    $$ |$$ |  $$/ $$ |  $$/ $$    $$ |$$      \       $$$$$$$  | /    $$ |$$   $$<  $$    $$ |$$ |  $$/ $$ |  $$ |$$/ 
      $$ |      $$ |$$$$$$$$/ $$ |      $$ |      $$$$$$$$/  $$$$$$  |      $$ |__$$ |/$$$$$$$ |$$$$$$  \ $$$$$$$$/ $$ |      $$ \__$$ | __ 
      $$ |      $$ |$$       |$$ |      $$ |      $$       |/     $$/       $$    $$/ $$    $$ |$$ | $$  |$$       |$$ |      $$    $$ |/  |
      $$/       $$/  $$$$$$$/ $$/       $$/        $$$$$$$/ $$$$$$$/        $$$$$$$/   $$$$$$$/ $$/   $$/  $$$$$$$/ $$/        $$$$$$$ |$$/ 
                                                                                                                              /  \__$$ |    
                                                                                                                              $$    $$/     
                                                                                                                              $$$$$$/      
      ";
      
      Console.WriteLine(title);
      Console.WriteLine("We have a few specials today!");
      Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5.");
      Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5.");

      Console.WriteLine("Let's place your order! How many loaves of bread would you like?");
      int numOfBread = int.Parse(Console.ReadLine());
      Bread newBread = new Bread(numOfBread);

      Console.WriteLine("How many pastries would you like?");
      int numOfPastry = int.Parse(Console.ReadLine());
      Pastry newPastry = new Pastry(numOfPastry);

      Console.WriteLine($"Your total is {newBread.BreadPriceTotal(numOfBread)} plus {newPastry.PastryPriceTotal(numOfPastry)}");
      // Console.WriteLine($"Ok, {numberOfPastry}. Would you like anything else? ['Y' for yes, 'Enter' for no]");
    }
  }
}