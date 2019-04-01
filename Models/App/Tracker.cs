namespace golfCard.Models {
  class Tracker {
    public List<Course> Courses { get; private set; }

    public void AddCourse (string name, int holes, int par) {
      Courses.Add (new Course (name, holes, par));
    }
  }
}