using System.Collections.Generic;
using System.Threading.Tasks;
using BlogEngine.Application.Interfaces;
using BlogEngine.Application.Services;
using BlogEngine.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace BlogEngine.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _service;

        public PostsController(IPostService service)
        {
            _service = service;

        }

        [HttpGet]
        public async Task<PostListViewModel> Get()
        {
            return await _service.GetAll();
        }

        // GET api/<PostsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var model =  await _service.GetById(id);
            if(model == null)
            {
                return NotFound();
            }
            return Ok(model);
        }

        // POST api/<PostsController>
        [HttpPost]
        public async Task Post([FromBody] PostViewModel value)
        {
            await _service.Create(value);
        }

        // PUT api/<PostsController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] PostViewModel value)
        {

        }

        // DELETE api/<PostsController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _service.Delete(id);
        }
    }
}
