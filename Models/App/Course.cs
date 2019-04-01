namespace golfCard.Models {
  class Course {
    public string Name { get; private set; }

    public int Holes { get; private set; }

    public int Par { get; private set; }

    public Course (string name, int holes, int par) {
      Name = name;
      Holes = holes;
      Par = par;
    }
  }
}