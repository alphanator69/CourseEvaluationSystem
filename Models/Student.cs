public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public ICollection<Evaluation> Evaluations { get; set; }
}
