using Microsoft.AspNetCore.Mvc;
using Application.Entitys;

namespace Application.Controllers;

[Route("/v1/books")]
[ApiController]
class BooksController : ControllerBase
{
    /*
    *   Instanciations and dependency injections
    */
    private readonly HttpContext _httpCtx;

    public BooksController(IHttpContextAccessor httpContextAccessor)
    {
        _httpCtx = httpContextAccessor.HttpContext;
    }

    /*
    *   Return all books
    */
    [HttpGet]
    public IActionResult GetAll()
    {
        throw new NotImplementedException();
    }

    /*
    *   Return a book by its id
    */
    [HttpGet("{id}")]
    public IActionResult GetByID(string id)
    {
        throw new NotImplementedException();
    }

    /*
    *   Insert a book
    */
    [HttpPost]
    public Task<IActionResult> InsertBook([FromBody] Book book)
    {
        throw new NotImplementedException();
    }

    /*
    *   Update a book
    */
    [HttpPut]
    public Task<IActionResult> UpdateBook([FromBody] Book book)
    {
        throw new NotImplementedException();
    }

    /*
    *   Delete a book by its id
    */
    [HttpDelete("/delete/{id}")]
    public Task<IActionResult> DeleteBook(string id)
    {
        throw new NotImplementedException();
    }
}