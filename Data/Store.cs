namespace MagicCotador;

public class Store
{
    public string Name { get; set; } = null!;
    public List<StoreCard> CardsInStock { get; set; } = new List<StoreCard>();
}