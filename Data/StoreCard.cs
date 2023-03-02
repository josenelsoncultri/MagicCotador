namespace MagicCotador;

public class StoreCard
{
    public string Store { get; init; } = string.Empty;
    public decimal Price { get; init; }

    public StoreCard(string _store, decimal _price)
    {
        this.Store = _store;
        this.Price = _price;
    }
}