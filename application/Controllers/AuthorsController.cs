using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers;

[Route("/v1/authors")]
[ApiController]
public class AuthorsController : ControllerBase
{
    private static List<Author> authors = new List<Author>();

    [HttpGet]
    public ActionResult GetAll()
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public ActionResult GetByID(String id)
    {
        throw new NotImplementedException();
    }
}