using Microsoft.AspNetCore.Mvc;
using Application.Models;

namespace Application.Controllers;

[Route("/v1/genres")]
[ApiController]
public class GenresController : ControllerBase
{
    private static List<Genre> genres = new List<Genre>();

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