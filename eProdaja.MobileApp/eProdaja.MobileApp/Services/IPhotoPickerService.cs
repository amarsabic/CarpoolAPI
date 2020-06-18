using System.IO;
using System.Threading.Tasks;

namespace eProdaja.MobileApp.Services
{
    public interface IPhotoPickerService
    {
        Task<Stream> GetImageStreamAsync();
    }
}