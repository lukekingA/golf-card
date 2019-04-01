using System.Collections.Generic;

namespace golfCard.Models {
  class Game {
    public List<Player> Players { get; private set; }

    public void AddPlayer (string name) {
      Players.Add (new Player (name));
    }

  }
}