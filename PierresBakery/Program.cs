using PierresBakery.Models;
using System;

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
                                                                                                                                            
                                                                                                                                            
                                                                                                                                            
       _______   __                                         __               _______             __                                       __ 
      /       \ /  |                                       /  |             /       \           /  |                                     /  |
      $$$$$$$  |$$/   ______    ______    ______    ______ $$/_______       $$$$$$$  |  ______  $$ |   __   ______    ______   __    __  $$ |
      $$ |__$$ |/  | /      \  /      \  /      \  /      \$//       |      $$ |__$$ | /      \ $$ |  /  | /      \  /      \ /  |  /  | $$ |
      $$    $$/ $$ |/$$$$$$  |/$$$$$$  |/$$$$$$  |/$$$$$$  |/$$$$$$$/       $$    $$<  $$$$$$  |$$ |_/$$/ /$$$$$$  |/$$$$$$  |$$ |  $$ | $$ |
      $$$$$$$/  $$ |$$    $$ |$$ |  $$/ $$ |  $$/ $$    $$ |$$      \       $$$$$$$  | /    $$ |$$   $$<  $$    $$ |$$ |  $$/ $$ |  $$ | $$/ 
      $$ |      $$ |$$$$$$$$/ $$ |      $$ |      $$$$$$$$/  $$$$$$  |      $$ |__$$ |/$$$$$$$ |$$$$$$  \ $$$$$$$$/ $$ |      $$ \__$$ |  __ 
      $$ |      $$ |$$       |$$ |      $$ |      $$       |/     $$/       $$    $$/ $$    $$ |$$ | $$  |$$       |$$ |      $$    $$ | /  |
      $$/       $$/  $$$$$$$/ $$/       $$/        $$$$$$$/ $$$$$$$/        $$$$$$$/   $$$$$$$/ $$/   $$/  $$$$$$$/ $$/        $$$$$$$ | $$/ 
                                                                                                                              /  \__$$ |    
                                                                                                                              $$    $$/     
                                                                                                                               $$$$$$/      
      ";
      
      Console.WriteLine(title);
      string menu = @"
      ----------------------------------------------------------------------------------------------------------------------------------------
       __  __                  
      |  \/  |                 
      | \  / | ___ _ __  _   _ 
      | |\/| |/ _ \ '_ \| | | |
      | |  | |  __/ | | | |_| |
      |_|  |_|\___|_| |_|\__,_|
                          
      Bread         $5 each       or        Buy 2, Get one Free!
      Pastry        $2 each       or        Buy 3 for $5!

      ----------------------------------------------------------------------------------------------------------------------------------------

      ";
      Console.WriteLine(menu);

      Console.WriteLine("Let's place your order! How many loaves of bread would you like?");
      string inputBread = Console.ReadLine();
      int numOfBread;
      bool parseBreadSuccess = int.TryParse(inputBread, out numOfBread);
      Bread newBread = new Bread(numOfBread);
      if (parseBreadSuccess)
      {
        Console.WriteLine($"That brings your subtotal to: $ {newBread.BreadPriceTotal()}. How many pastries would you like to add?");
      }
      else
      {
        Console.WriteLine("This is not a valid input! Now you have to start over!");
        Main();
      }

      string inputPastry = Console.ReadLine();
      int numOfPastry;
      bool parsePastrySuccess = int.TryParse(inputPastry, out numOfPastry);
      Pastry newPastry = new Pastry(numOfPastry);
      if (parsePastrySuccess)
      {
        Console.WriteLine($"Your grand total is: $ {newBread.BreadPriceTotal() + newPastry.PastryPriceTotal()}");
      }
      else
      {
        Console.WriteLine("This is not a valid input! Now you have to start over!");
        Main();
      }
      string croissant = @"
         ____                                    ?~~bL
        z@~ b                                    |  `U,
      ]@[  |                                   ]'  z@'
      d@~' `|, .__     _----L___----, __, .  _t'   `@j
      `@L_,   '-~ `--'~-a,           `C.  ~''O_    ._`@
      q@~'   ]P       ]@[            `Y=,   `H+z_  `a@
      `@L  _z@        d@               Ya     `-@b,_a'
        `-@d@a'       )@[               `VL      `a@@'
          aa~'   ],  .a@'                qqL  ), ./~
          @@_  _z~  _d@[                 .V@  .L_d'
          '~@@@'  ]@@@'        __      )@n@bza@-'
            `-@zzz@@@L        )@@z     ]@@=%-'
              '~~@@@@@bz_    _a@@@@z___a@K
                  '~-@@@@@@@@@@@@@@@@@@~'
                      `~~~-@~~-@@~~~~~`

      ";
      string goodbye = @"
      
       ________  __                           __                                             __ 
      /        |/  |                         /  |                                           /  |
      $$$$$$$$/$$  |___    ______   _______  $$ |   __        __    __   ______   __    __  $$ |
        $$ |   $$      \  /      \ /       \ $$ |  /  |      /  |  /  | /      \ /  |  /  | $$ |
        $$ |   $$$$$$$  | $$$$$$  |$$$$$$$  |$$ |_/$$/       $$ |  $$ |/$$$$$$  |$$ |  $$ | $$ |
        $$ |   $$ |  $$ | /    $$ |$$ |  $$ |$$   $$<        $$ |  $$ |$$ |  $$ |$$ |  $$ | $$/ 
        $$ |   $$ |  $$ |/$$$$$$$ |$$ |  $$ |$$$$$$  \       $$ \__$$ |$$ \__$$ |$$ \__$$ | __ 
        $$ |   $$ |  $$ |$$    $$ |$$ |  $$ |$$ | $$  |      $$    $$ |$$    $$/ $$    $$/ /  |
        $$/    $$/   $$/  $$$$$$$/ $$/   $$/ $$/   $$/        $$$$$$$ | $$$$$$/   $$$$$$/  $$/ 
                                                             /  \__$$ |                        
                                                             $$    $$/                         
                                                              $$$$$$/                          
                                                                                          
      ";
      Console.WriteLine(goodbye);
      Console.WriteLine(croissant);
    }
  }
}