using System;
namespace rps
{
  class Program
  {
    static void Main(string[] args)
    {
      void gameOn()
      {
        Console.Clear();
        Console.WriteLine(@"
      Welcome to Rock Paper Scissors!!!");

        System.Console.WriteLine(@"

               | |   
 _ __ ___   ___| | __
| '__/ _ \ / __| |/ /
| | | (_) | (__|   < 
|_|  \___/ \___|_|\_\

_ __   __ _ _ __   ___ _ __             ______________________  
| '_ \ / _` | '_ \ / _ \ '__|          |XXXXXXX|==============| 
| |_) | (_| | |_) |  __/ |             |XXXXXXX|==============| 
| .__/ \__,_| .__/ \___|_|             |XXXXXXX|==============| 
| |         | |                        |XXXXXXX|==============|
|_|         |_|                        |======================| 
                                       |======================|
         (_)                           |======================|
 ___  ___ _ ___ ___  ___  _ __ ___      ~~~~~~~~~~~~~~~~~~~~~~   
/ __|/ __| / __/ __|/ _ \| '__/ __|
\__ \ (__| \__ \__ \ (_) | |  \__ \
|___/\___|_|___/___/\___/|_|  |___/

    
           ");


        System.Console.WriteLine("Please enter your choice (1 = Rock, 2 = Paper, 3 = Scissors");
        int input = Int32.Parse(System.Console.ReadLine());
        if (input != 1 && input != 2 && input != 3)
        {
          System.Console.WriteLine(@"
          
         _________ _______    _______  _______  _______ 
|\     /|\__   __/(  ____ \  (  ___  )(  ____ )(  ____ \
| )   ( |   ) (   | (    \/  | (   ) || (    )|| (    \/
| | _ | |   | |   | (__      | (___) || (____)|| (__    
| |( )| |   | |   |  __)     |  ___  ||     __)|  __)   
| || || |   | |   | (        | (   ) || (\ (   | (      
| () () |   | |   | )        | )   ( || ) \ \__| (____/\
(_______)   )_(   |/         |/     \||/   \__/(_______/
                                                        
          _______          
|\     /|(  ___  )|\     /|
( \   / )| (   ) || )   ( |
 \ (_) / | |   | || |   | |
  \   /  | |   | || |   | |
   ) (   | |   | || |   | |
   | |   | (___) || (___) |
   \_/   (_______)(_______)
                           
 ______   _______ _________ _        _______   _____   _ 
(  __  \ (  ___  )\__   __/( (    /|(  ____ \ / ___ \ ( )
| (  \  )| (   ) |   ) (   |  \  ( || (    \/( (   ) )| |
| |   ) || |   | |   | |   |   \ | || |       \/  / / | |
| |   | || |   | |   | |   | (\ \) || | ____     ( (  | |
| |   ) || |   | |   | |   | | \   || | \_  )    | |  (_)
| (__/  )| (___) |___) (___| )  \  || (___) |    (_)   _ 
(______/ (_______)\_______/|/    )_)(_______)     _   (_)
                                                 (_)   
          ");
          gameOn();
        }
        Random mathRandomTool = new Random();
        int response = mathRandomTool.Next(1, 4);
        System.Console.WriteLine(response);
        string win = @"
        
                                         .''.
       .''.             *''*    :_\/_:     . 
      :_\/_:   .    .:.*_\/_*   : /\ :  .'.:.'.
  .''.: /\ : _\(/_  ':'* /\ *  : '..'.  -=:o:=-
 :_\/_:'.:::. /)\*''*  .|.* '.\'/.'_\(/_'.':'.'
 : /\ : :::::  '*_\/_* | |  -= o =- /)\    '  *
  '..'  ':::'   * /\ * |'|  .'/.\'.    '._____
      *        __*..* |  |     :        |.   |' .---' |
        _ *   .- '   ' -. |  |      .--'|    ||   | _|    |
     .- '|  _.|  |    ||  ' - __ |   |  |    ||      |
     | ' | |.    |    ||       | |   |  |    ||      |
 ___ | '-'     '      ''       '-'   ' -.'    '`      | ____
jgs~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


          _______                     _________ _        _
|\     /|(  ___  )|\     /|  |\     /|\__   __/( (    /|( )
( \   / )| (   ) || )   ( |  | )   ( |   ) (   |  \  ( || |
 \ (_) / | |   | || |   | |  | | _ | |   | |   |   \ | || |
  \   /  | |   | || |   | |  | |( )| |   | |   | (\ \) || |
   ) (   | |   | || |   | |  | || || |   | |   | | \   |(_)
   | |   | (___) || (___) |  | () () |___) (___| )  \  | _ 
   \_/   (_______)(_______)  (_______)\_______/|/    )_)(_)
        

        ";

        string lose = @"
          _______             _        _______  _______  _______  _        
|\     /|(  ___  )|\     /|  ( \      (  ___  )(  ____ \(  ____ \( )
( \   / )| (   ) || )   ( |  | (      | (   ) || (    \/| (    \/| |
 \ (_) / | |   | || |   | |  | |      | |   | || (_____ | (__    | |
  \   /  | |   | || |   | |  | |      | |   | |(_____  )|  __)   | |
   ) (   | |   | || |   | |  | |      | |   | |      ) || (      (_)
   | |   | (___) || (___) |  | (____/\| (___) |/\____) || (____/\ _ 
   \_/   (_______)(_______)  (_______/(_______)\_______)(_______/(_)
        
        ";
        string tie = @"
__________________ _______  _ 
\__   __/\__   __/(  ____ \( )
   ) (      ) (   | (    \/| |
   | |      | |   | (__    | |
   | |      | |   |  __)   | |
   | |      | |   | (      (_)
   | |   ___) (___| (____/\ _ 
   )_(   \_______/(_______/(_)
                              
        
        ";
        string question = "Would you like to play again? Enter Y or N";
        if (input == response)
        {

          System.Console.Clear();
          System.Console.WriteLine(tie);
          System.Console.WriteLine(question);
          string playAgain = System.Console.ReadLine();
          if (playAgain.ToLower() == "y")
          {
            gameOn();
          }
        }
        else if (input == 1 && response == 2)
        {
          System.Console.Clear();
          System.Console.WriteLine(lose);
          System.Console.WriteLine(question);
          string playAgain = System.Console.ReadLine();
          if (playAgain.ToLower() == "y")
          {
            gameOn();
          }
        }
        else if (input == 1 && response == 3)
        {
          System.Console.Clear();
          System.Console.WriteLine(win);
          System.Console.WriteLine(question);
          string playAgain = System.Console.ReadLine();
          if (playAgain.ToLower() == "y")
          {
            gameOn();
          }
        }
        else if (input == 2 && response == 1)
        {
          System.Console.Clear();
          System.Console.WriteLine(win);
          System.Console.WriteLine(question);
          string playAgain = System.Console.ReadLine();
          if (playAgain.ToLower() == "y")
          {
            gameOn();
          }
        }
        else if (input == 2 && response == 3)
        {
          System.Console.Clear();
          System.Console.WriteLine(lose);
          System.Console.WriteLine(question);
          string playAgain = System.Console.ReadLine();
          if (playAgain.ToLower() == "y")
          {
            gameOn();
          }
        }
        else if (input == 3 && response == 1)
        {
          System.Console.Clear();
          System.Console.WriteLine(lose);
          System.Console.WriteLine(question);
          string playAgain = System.Console.ReadLine();
          if (playAgain.ToLower() == "y")
          {
            gameOn();
          }
        }
        else if (input == 3 && response == 1)
        {
          System.Console.Clear();
          System.Console.WriteLine(win);
          System.Console.WriteLine(question);
          string playAgain = System.Console.ReadLine();
          if (playAgain.ToLower() == "y")
          {
            gameOn();
          }
        }

      }
      gameOn();

    }
  }
}
