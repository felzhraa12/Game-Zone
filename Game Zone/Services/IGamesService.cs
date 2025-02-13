namespace Game_Zone.Services
{
    public interface IGamesService
    {
        Task Create(CreateGameFormViewModel model);
    }
}
