namespace Game_Zone.Services
{
    public interface ICategoriesService
    {
        public IEnumerable<SelectListItem> GetSelectList();
    }
}
