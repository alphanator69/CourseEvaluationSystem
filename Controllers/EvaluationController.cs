public class EvaluationController : Controller
{
    private readonly EvaluationContext _context;

    public EvaluationController(EvaluationContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Create(int courseId)
    {
        ViewBag.CourseID = courseId;
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Evaluation evaluation)
    {
        if (!ModelState.IsValid)
            return View(evaluation);

        _context.Add(evaluation);
        await _context.SaveChangesAsync();
        return RedirectToAction("Confirmation");
    }

    public IActionResult Confirmation()
    {
        return View();
    }
}
