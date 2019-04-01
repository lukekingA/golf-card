using System.Collections.Generic;

namespace golfCard.Models {
  class Player {
    public string Name { get; private set; }

    public List<int> Scores { get; private set; }

    public void AddScore (int score) {
      Scores.Add (score);
    }

    public Player (string name) {
      Name = name;
      Scores = new List<int> ();
    }
  }
}