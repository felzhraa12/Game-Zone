namespace Game_Zone.Models
{
    public class Game : BaseEntity
    {
       
        [MaxLength(2500)]
        public string? Description { get; set; }

        [MaxLength(500)]
        public string? Cover { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; } = default!;

        public ICollection<GameDevice> Device { get; set; } = new List<GameDevice>();   

    }
}
