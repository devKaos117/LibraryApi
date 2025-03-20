using Microsoft.AspNetCore.Mvc;
using Application.Entitys;
using Application.Modules;

namespace Application.Controllers;

[Route("/v1/authors")]
[ApiController]
public class AuthorsController : ControllerBase
{
    /*
    *   Instanciations and dependency injections
    */
    private readonly HttpContext _httpCtx;

    public AuthorsController(IHttpContextAccessor httpContextAccessor)
    {
        _httpCtx = httpContextAccessor.HttpContext;
    }

    /*
    *   Return all authors
    */
    [HttpGet]
    public IActionResult GetAll()
    {
        throw new NotImplementedException();
    }

    /*
    *   Return a author by its id
    */
    [HttpGet("{id}")]
    public IActionResult GetByID(string id)
    {
        throw new NotImplementedException();
    }

    /*
    *   Insert a author
    */
    [HttpPost]
    public Task<IActionResult> InsertAuthor([FromBody] Author author)
    {
        throw new NotImplementedException();
    }

    /*
    *   Update a author
    */
    [HttpPut]
    public Task<IActionResult> UpdateAuthor([FromBody] Author author)
    {
        throw new NotImplementedException();
    }

    /*
    *   Delete a author by its id
    */
    [HttpDelete("/delete/{id}")]
    public Task<IActionResult> DeleteAuthor(string id)
    {
        throw new NotImplementedException();
    }
}