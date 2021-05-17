using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VnExpress.Application.Posts;
using VnExpress.ViewModel.Posts;

namespace VnExpress.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : Controller
    {
        private readonly IPostService _postService;

        public PostsController(IPostService postService)
        {
            _postService = postService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var posts = await _postService.GetAll();
            return Ok(posts);
        }
        [HttpGet("{postId}")]

        public async Task<IActionResult> GetById(int postId)
        {
            var post = await _postService.GetById(postId);
            if (post == null)
                return BadRequest("Cannot find post");
            return Ok(post);
        }
        [HttpPost]
        [Consumes("multipart/form-data")]
        
        public async Task<IActionResult> Create([FromForm] PostCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var postId = await _postService.Create(request);
            if (postId == 0)
                return BadRequest();

            var post = await _postService.GetById(postId);

            return CreatedAtAction(nameof(GetById), new { id = postId }, post);
        }

        

        [HttpPut("{postId}")]
        [Consumes("multipart/form-data")]
        
        public async Task<IActionResult> Update([FromRoute] int postId, [FromForm] PostUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            request.Id = postId;
            var affectedResult = await _postService.Update(request);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }

        [HttpDelete("{postId}")]
        
        public async Task<IActionResult> Delete(int postId)
        {
            var affectedResult = await _postService.Delete(postId);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }

    }
}
