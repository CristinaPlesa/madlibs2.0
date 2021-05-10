using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Home() { return View(); }

    [Route("/FairyForm")]
    public ActionResult FairyForm() { return View(); }

    [Route("/FairyTale")]
    public ActionResult FairyTale(string adjective, string noun, string noun2, string pastTenseVerb)
    {
      MadLibsGame FairyMadLibs = new MadLibsGame();
      FairyMadLibs.Adjective = adjective;
      FairyMadLibs.Noun = noun;
      FairyMadLibs.Noun2 = noun2;
      FairyMadLibs.PastTenseVerb = pastTenseVerb;
      return View(FairyMadLibs);
    }

    [Route("/SciFiForm")]
    public ActionResult SciFiForm() { return View(); }

    [Route("/SciFiTale")]
    public ActionResult SciFiTale(string adjective, string noun, string noun2, string noun3, string pastTenseVerb)
    {
      MadLibsGame SciFiMadLibs = new MadLibsGame();
      SciFiMadLibs.Adjective = adjective;
      SciFiMadLibs.Noun = noun;
      SciFiMadLibs.Noun2 = noun2;
      SciFiMadLibs.Noun2 = noun3;
      SciFiMadLibs.PastTenseVerb = pastTenseVerb;
      return View(SciFiMadLibs);
    }
  }
}