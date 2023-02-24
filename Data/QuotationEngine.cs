namespace MagicCotador;

public class QuotationEngine
{
    public Card GetCardData(string _cardName)
    {
        Card _returnCard = new Card(_cardName);

        //TODO: Executar busca na ligamagic e processar as lojas

        return _returnCard;
    }
}