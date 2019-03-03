using System;
using Microsoft.AspNetCore.Mvc;

using System.Text.Encodings.Web;


namespace Percival.Controllers {
  public class LaunchController: Controller{
    //
    // GET: /
    public IActionResult Index(){
//      foreach(LaunchInfo i in launchSet.Data)
//        Console.WriteLine(i);
      return View();
    }
    public IActionResult Details(string id){
      ViewData["id"] = id;
      return View();
    }
  }
}
