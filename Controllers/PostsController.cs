using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace rnd_dotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Post> GetAllPosts()
        {
            var posts = new List<Post> {
                new Post { 
                    Id = 1,
                    Title = "Lorem Ipsum",
                    Body = "Lorem ipsum dolor sit amet"
                },
                 new Post { 
                    Id = 2,
                    Title = "Lorem Ipsum II",
                    Body = "Lorem ipsum dolor sit amet"
                },
            };
            return posts;
        }

        [HttpGet("{id}")]
        public Post GetPost(int Id)
        {
            var post = new Post() {
                Id = 1,
                Title = "Lorem Ipsum",
                Body = "Lorem ipsum dolor sit amet"
            };

            return post;
        }

        [HttpPost]
        public ActionResult CreatePost()
        {
            return Content("Hello");
        }
    }
}
