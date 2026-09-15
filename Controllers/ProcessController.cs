namespace MvcRocks.Controllers;

public class ProcessController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Procs = Process.GetProcesses();
        return View();
    }

    [Authorize]
    public IActionResult ProcessDetails(int id)
    {
        ViewBag.Proc = Process.GetProcessById(id);
        return View();
    }

    public IActionResult ConcreteIndex()
    {
        return View(Process.GetProcesses());
    }

    [Authorize]
    public IActionResult ConcreteProcessDetails(int id)
    {
        return View(Process.GetProcessById(id));
    }
}