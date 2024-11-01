
using Microsoft.AspNetCore.Mvc;
using VideoStore.Manager;

namespace VideoStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class VideoController : Controller
    {
        private readonly VideoManager _videoManager;

        public VideoController(VideoManager videoManager)
        {
            _videoManager = videoManager;
        }

        [HttpGet]
        public IActionResult GetAllVideos()
        {
            return Ok(_videoManager.GetAll());
        }


    }
}
