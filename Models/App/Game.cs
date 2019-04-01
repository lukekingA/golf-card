using System.Collections.Generic;

namespace golfCard.Models {
  class Game {
    public List<Player> Players { get; private set; }

    public void AddPlayer (string name) {
      Players.Add (new Player (name));
    }

    public List<Player> WinStatus () {
      List<Player> Winner = new List<Player> ();
      int highest = Players[0].Total ();
      Winner.Add (Players[0]);
      for (int i = 1; i < Players.Count; i++) {
        if (Players[i].Total () == highest) {
          Winner.Add (Players[i]);
        }
        if (Players[i].Total () > highest) {
          Winner.Clear ();
          Winner.Add (Players[i]);
          highest = Players[i].Total ();
        }
      }
      return Winner;
    }

    public List<Course> Courses { get; private set; }

    public void AddCourse (string name, int holes, int par) {
      Courses.Add (new Course (name, holes, par));
    }

    public Game () {
      Players = new List<Player> ();
      Courses = new List<Course> (); { new Course ("Nine", 9, 30); } { new Course ("Eighteen", 18, 60) }
    }
  }
}