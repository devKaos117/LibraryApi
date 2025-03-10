using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers;

[Route("/v1/books")]
[ApiController]
class BooksController : ControllerBase
{
    [HttpGet]
    public ActionResult GetAll()
    {
        // ActionResult<Dictionary<int, Book>>
        return Ok("{id: {\"id\": n, \"isbn13\": \"XXXXXXXXXXXXX\", \"title\": \"...\", \"subtitle\": \"...\", \"language\": \"pt_br\", \"release\": \"XXXX-XX-XX\", \"description\": \"..\"}}");
    }

    [HttpGet("{id}")]
    public ActionResult GetByID(String id)
    {
        // ActionResult<Book>
        return Ok("{\"id\": n, \"isbn13\": \"XXXXXXXXXXXXX\", \"title\": \"...\", \"subtitle\": \"...\", \"language\": \"pt_br\", \"release\": \"XXXX-XX-XX\", \"description\": \"..\"}");
    }

    [HttpPost("/books")]

    public ActionResult InsertBook(HttpContext ctx)
    {
        // async Task
        return Created("uri", new Book());
    }
}