namespace MagicCotador;

public class BuyerCard : ICard
{
    public string Name { get; set; } = null!;
    public bool Priority { get; set; }
}