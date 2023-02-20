namespace MagicCotador;

public class StoreCard : ICard
{
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
}