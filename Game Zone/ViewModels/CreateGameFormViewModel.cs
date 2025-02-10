using Microsoft.AspNetCore.Mvc.Rendering;

namespace Game_Zone.ViewModels
{
    public class CreateGameFormViewModel
    {
        [MaxLength(250)]
        public string? Name { get; set; }

        public int CategoryId { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; } = Enumerable.Empty<SelectListItem>();

        public List<int> SelectedDevices { get; set; } = new List<int>();

        public IEnumerable<SelectListItem> Devices { get; set; } = Enumerable.Empty<SelectListItem>();

        public string? Description { get; set; }

        public IFormFile Cover { get; set; } = default!;
    }
}
