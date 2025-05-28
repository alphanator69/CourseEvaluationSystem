public class CourseController : Controller
{
    private readonly EvaluationContext _context;

    public CourseController(EvaluationContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var courses = await _context.Courses.ToListAsync();
        return View(courses);
    }
}
