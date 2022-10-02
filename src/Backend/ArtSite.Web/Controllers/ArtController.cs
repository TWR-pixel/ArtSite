using ArtSite.Data.Models;
using ArtSite.Domain.Implementation;
using ArtSite.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ArtSite.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class ArtController : ControllerBase
{
    private readonly IArtRepository _repository;

    public ArtController(IArtRepository repository)
    {
        _repository = repository;
    }

    [HttpPost]
    public async Task<ActionResult> Create(Art art)
    {
        if (art is null)
        {
            return BadRequest();
        }
        await _repository.CreateAndSave(art);
        
        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<Art> GetById(Guid id)
    {
        return await _repository.GetById(id);
    }

    [HttpGet]
    public async Task<IList<Art>> GetAll()
    {
        return await _repository.GetAll();
    }
}