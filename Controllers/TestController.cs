using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using static System.TimeZoneInfo;
using static System.DateTime;

namespace ASP_example.Controllers;

public class TestController: Controller
{
    public string Index(int id)
    {
        return $"Hello 你好! ASP.NET core!\n{id}";
    }

    public IActionResult Template()
    {
        TimeZoneInfo timezone = Local;
        DateTime now_time = DateTime.Now;
        ViewData["time"] = now_time + " " + Local.Id;
        ViewData["text"] = "hahaha";
        return View();
    }
}