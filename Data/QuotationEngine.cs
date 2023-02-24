using AngleSharp;

namespace MagicCotador;

public class QuotationEngine
{
    public async Task<Card> GetCardData(string _cardName)
    {
        Card _returnCard = new Card(_cardName);

        //TODO: Executar busca na ligamagic e processar as lojas
        /*
        var config = Configuration.Default.WithDefaultLoader();
        using var context = BrowsingContext.New(config);
        using var doc = await context.OpenAsync("https://www.ligamagic.com.br/?view=cards/card&card=platinum%20angel");
        //cardName = doc.QuerySelector("p.nome-principal").GetAttribute("title");
        cardName = doc.DocumentElement.QuerySelector("p.nome-principal > span").InnerHtml;
        */

        return _returnCard;
    }
}