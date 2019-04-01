using System;
using golfCard;

namespace golfCard {
  class Program {
    static void Main (string[] args) {
      System.Console.WriteLine ("Golf Game Tracker");
      Tracker tracker = new Tracker ();
      tracker.Run ();
    }
  }
}