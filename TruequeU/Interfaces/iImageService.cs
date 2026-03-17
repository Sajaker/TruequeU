using Microsoft.EntityFrameworkCore;
using TruequeU.Models;
using static System.Net.Mime.MediaTypeNames;

namespace TruequeU.Interfaces
{
    public interface iImageService
    {
        Task<Images> addImage(Images newImg, string identifier);
        Task deleteImage(Guid image_id, string identifier);
        Task<List<Images>?> getImagesByListing(Guid listing_id);

    }
}


