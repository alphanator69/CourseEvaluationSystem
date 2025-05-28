public class AdminController : Controller
{
    private readonly EvaluationContext _context;

    public AdminController(EvaluationContext context)
    {
        _context = context;
    }

    public IActionResult Summary()
    {
        var summary = _context.Courses
            .Select(c => new
            {
                c.Title,
                AverageRating = c.Evaluations.Any() ? c.Evaluations.Average(e => e.Rating) : 0,
                Comments = c.Evaluations.Select(e => e.Comment).ToList()
            });

        return View(summary);
    }
}
