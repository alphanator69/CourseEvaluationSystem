public class Evaluation
{
    public int ID { get; set; }

    [Range(1, 5)]
    public int Rating { get; set; }

    public string Comment { get; set; }

    public DateTime Date { get; set; } = DateTime.Now;

    public int StudentID { get; set; }
    public Student Student { get; set; }

    public int CourseID { get; set; }
    public Course Course { get; set; }
}
