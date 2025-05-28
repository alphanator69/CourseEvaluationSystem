public class EvaluationTests
{
    [Fact]
    public void Evaluation_Requires_Rating()
    {
        var evaluation = new Evaluation();
        var context = new ValidationContext(evaluation, null, null);
        var results = new List<ValidationResult>();

        var isValid = Validator.TryValidateObject(evaluation, context, results, true);

        Assert.False(isValid);
        Assert.Contains(results, r => r.MemberNames.Contains("Rating"));
    }

    [Fact]
    public void AverageRating_IsCalculatedCorrectly()
    {
        var evaluations = new List<Evaluation>
        {
            new Evaluation { Rating = 4 },
            new Evaluation { Rating = 5 },
            new Evaluation { Rating = 3 }
        };

        var average = evaluations.Average(e => e.Rating);
        Assert.Equal(4.0, average);
    }
}
