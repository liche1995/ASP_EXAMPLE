using System.ComponentModel.DataAnnotations;
using static System.DateTime;

namespace ASP_example.Models;

public class Post
{
    public int id  {get; set;}
    public required string title {get; set;} //declear not nullable
    public int author {get; set;}
    public DateTime create_time {get; set;}
    public DateTime edit_time {get; set;}
    public bool soft_delete {get; set;}
}
