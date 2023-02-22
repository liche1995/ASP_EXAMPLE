using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ASP_example.Controllers;

public class TestController: Controller
{
    public string Index(int id)
    {
        return $"Hello 你好! ASP.NET core!\n{id}";
    }
}