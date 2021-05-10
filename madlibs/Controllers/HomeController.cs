using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/Story")]
    public ActionResult Story(string adjective, string noun, string noun2, string pastTenseVerb)
    {
      MadLibsGame firstMabLibs = new MadLibsGame();
      firstMabLibs.Adjective = adjective;
      firstMabLibs.Noun = noun;
      firstMabLibs.Noun2 = noun2;
      firstMabLibs.PastTenseVerb = pastTenseVerb;
      return View(firstMabLibs);
    }
  }
}