using Microsoft.EntityFrameworkCore;
using VideoStore.Model;

namespace VideoStore.Manager
{
    public class VideoManager
    {
        private readonly VideoStoreDataContext _videoStoreDataContext;

        public VideoManager(VideoStoreDataContext videoStoreDataContext)
        {
            _videoStoreDataContext = videoStoreDataContext;
        }

        public IEnumerable<Video> GetAll()
        {
            var videos = _videoStoreDataContext.Videos.AsNoTracking().ToList();
            return videos;
        }
    }
}
