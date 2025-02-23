using Game_Zone.Attributes;

namespace Game_Zone.ViewModels
{
    public class CreateGameFormViewModel : GameFormViewModel
    {
        

        [ALlowedExtensions(FileSettings.AllowedExtensions)]
        [MaxFileSize(FileSettings.MaxFileSizeInBytes)]
        public IFormFile Cover { get; set; } = default!;
    }
}
