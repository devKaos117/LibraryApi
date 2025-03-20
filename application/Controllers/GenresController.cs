using Microsoft.AspNetCore.Mvc;
using Application.Entitys;

namespace Application.Controllers;

[Route("/v1/genres")]
[ApiController]
public class GenresController : ControllerBase
{
    /*
    *   Instanciations and dependency injections
    */
    private readonly HttpContext _httpCtx;

    public GenresController(IHttpContextAccessor httpContextAccessor)
    {
        _httpCtx = httpContextAccessor.HttpContext;
    }

    /*
    *   Return all genres
    */
    [HttpGet]
    public IActionResult GetAll()
    {
        throw new NotImplementedException();
    }

    /*
    *   Return a genre by its id
    */
    [HttpGet("{id}")]
    public IActionResult GetByID(string id)
    {
        throw new NotImplementedException();
    }

    /*
    *   Insert a genre
    */
    [HttpPost]
    public Task<IActionResult> InsertGenre([FromBody] Genre genre)
    {
        throw new NotImplementedException();
    }

    /*
    *   Update a genre
    */
    [HttpPut]
    public Task<IActionResult> UpdateGenre([FromBody] Genre genre)
    {
        throw new NotImplementedException();
    }

    /*
    *   Delete a genre by its id
    */
    [HttpDelete("/delete/{id}")]
    public Task<IActionResult> DeleteGenre(string id)
    {
        throw new NotImplementedException();
    }
}