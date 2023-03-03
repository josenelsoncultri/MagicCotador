namespace MagicCotador;

public class StockItem
{
    public string Store { get; init; } = string.Empty;
    public decimal Price { get; init; }

    public StockItem(string _store, decimal _price)
    {
        this.Store = _store;
        this.Price = _price;
    }
}