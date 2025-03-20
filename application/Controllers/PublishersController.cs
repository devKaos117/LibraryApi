using Microsoft.AspNetCore.Mvc;
using Application.Entitys;

namespace Application.Controllers;

[Route("/v1/publishers")]
[ApiController]
class PublishersController : ControllerBase
{
    /*
    *   Instanciations and dependency injections
    */
    private readonly HttpContext _httpCtx;

    public PublishersController(IHttpContextAccessor httpContextAccessor)
    {
        _httpCtx = httpContextAccessor.HttpContext;
    }

    /*
    *   Return all publishers
    */
    [HttpGet]
    public IActionResult GetAll()
    {
        throw new NotImplementedException();
    }

    /*
    *   Return a publisher by its id
    */
    [HttpGet("{id}")]
    public IActionResult GetByID(string id)
    {
        throw new NotImplementedException();
    }

    /*
    *   Insert a publisher
    */
    [HttpPost]
    public Task<IActionResult> InsertPublisher([FromBody] Publisher publisher)
    {
        throw new NotImplementedException();
    }

    /*
    *   Update a publisher
    */
    [HttpPut]
    public Task<IActionResult> UpdatePublisher([FromBody] Publisher publisher)
    {
        throw new NotImplementedException();
    }

    /*
    *   Delete a publisher by its id
    */
    [HttpDelete("/delete/{id}")]
    public Task<IActionResult> DeletePublisher(string id)
    {
        throw new NotImplementedException();
    }
}