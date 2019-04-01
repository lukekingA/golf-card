using System.Collections.Generic;

namespace golfCard.Models {
  class Player {
    public string Name { get; private set; }

    public List<int> Scores { get; private set; }

    public void AddScore (int score) {
      Scores.Add (score);
    }

    public int Total () {
      int total = 0;
      foreach (int score in Scores) {
        total += score;
      }
      return total;
    }

    public Player (string name) {
      Name = name;
      Scores = new List<int> ();
    }
  }
}