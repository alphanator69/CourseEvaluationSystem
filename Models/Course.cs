public class Course
{
    public int ID { get; set; }
    public string Title { get; set; }

    public ICollection<Evaluation> Evaluations { get; set; }
}
