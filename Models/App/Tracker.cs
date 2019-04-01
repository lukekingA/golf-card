using System;
using System.Collections.Generic;
using golfCard.Models;

namespace golfCard {
  class Tracker {
    Game game = new Game ();

    public void Run () {
      while (true) {
        for (int i = 0; i < game.Courses.Count; i++) {
          Console.WriteLine ($"{i + 1}: {game.Courses[i].Name}");
        }
        Console.WriteLine ($@"
To choose a course from above please enter the number of the course.
If you want to enter a new course type (N) and fill out the fields.
");
        string choice = Console.ReadLine ();
        int choiceCourse;
        if (Int32.TryParse (choice, out choiceCourse) && choiceCourse <= game.Courses.Count + 1) {
          Console.Clear ();
          Console.WriteLine ("Please Enter the number of players in your party");
          string playerCount = Console.ReadLine ();
          if (this.validateNumber (playerCount)) {
            int loop = Int32.Parse (playerCount);
            Console.Clear ();

            for (int i = 0; i < loop; i++) {
              Console.WriteLine ($"Enter Player ({i + 1}) name.");
              string playerName = Console.ReadLine ();
              game.AddPlayer (playerName);
              Console.Clear ();
            }
            Console.WriteLine ("Ok. You are set up to begin. Press (Enter) continue.");
            ConsoleKeyInfo letsPlay = Console.ReadKey ();
            if (letsPlay.Key == ConsoleKey.Enter) {
              Console.Clear ();
              for (int i = 0; i < game.Courses[choiceCourse - 1].Holes; i++) {
                System.Console.WriteLine ($"Round: {i+1} of {game.Courses[choiceCourse -1].Holes}");
                for (int j = 0; j < game.Players.Count; j++) {
                  Console.WriteLine ($"Enter {game.Players[j].Name} score:");
                  bool goodScore = true;
                  string playerScore = Console.ReadLine ();
                  goodScore = !(validateNumber (playerScore));
                  while (goodScore) {
                    Console.WriteLine ("Not a number entry, try again.");
                    playerScore = Console.ReadLine ();
                    goodScore = !(validateNumber (playerScore));
                    continue;
                  }
                  game.Players[j].AddScore (Int32.Parse (playerScore));
                }
              }
              Console.Clear ();
              game.Players.ForEach (p => {
                System.Console.Write ($"{p.Name}: ");
                p.PlayerScores ();
              });
              game.WinStatus ();
              System.Console.WriteLine ("Press (Y) for another round or (Q) to quit");
              bool lastChoice = false;
              do {
                ConsoleKeyInfo key = Console.ReadKey ();
                if (key.Key.ToString () == "Y") {
                  lastChoice = false;
                  continue;
                } else if (key.Key.ToString () == "Q") {
                  lastChoice = false;
                  return;
                } else {
                  System.Console.WriteLine ("Not a valid responce. Choose (Y) or (Q).");
                }
              } while (lastChoice);
            }
          }

        } else if (choice.ToUpper () == " N ") {

        }

      }
    }

    public Tracker () {

    }

    public bool validateNumber (string entry) {
      return Int32.TryParse (entry, out int result);
    }

  }

}