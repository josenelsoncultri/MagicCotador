namespace MagicCotador;

public class Card
{
    public string Name { get; init; } = string.Empty;
    public List<StoreCard> Stores { get; set; } = null!;

    public Card(string _name)
    {
        this.Name = _name;
    }
}