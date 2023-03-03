namespace MagicCotador;

public class Card
{
    public string Name { get; init; } = string.Empty;
    public List<StockItem> Stock { get; set; } = null!;

    public Card(string _name)
    {
        this.Name = _name;
    }
}