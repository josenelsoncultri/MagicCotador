namespace MagicCotador;

public class Buyer 
{
    public string Name { get; set; } = null!;
    public List<BuyerCard> Wishlist { get; set; } = new List<BuyerCard>();
}