using AngleSharp;
using System.Web;

namespace MagicCotador;

public class QuotationEngine
{
    public async Task<Card> GetCardData(string _cardName)
    {
        Card _returnCard = new Card(_cardName);

        var config = Configuration.Default.WithDefaultLoader();
        using var context = BrowsingContext.New(config);
        using var doc = await context.OpenAsync("https://www.ligamagic.com.br/?view=cards/card&card=" + HttpUtility.UrlEncode(_cardName));

        //TODO: Executar busca na ligamagic e processar as lojas
        /*
        var config = Configuration.Default.WithDefaultLoader();
        using var context = BrowsingContext.New(config);
        using var doc = await context.OpenAsync("https://www.ligamagic.com.br/?view=cards/card&card=platinum%20angel");
        //cardName = doc.QuerySelector("p.nome-principal").GetAttribute("title");
        cardName = doc.DocumentElement.QuerySelector("p.nome-principal > span").InnerHtml;
        */

        for (int i = 0; i < doc.QuerySelectorAll(".estoque-linha").Count(); i++)
        {
            var store = doc.QuerySelectorAll(".estoque-linha")[i];

            string? _storeName = store!.QuerySelector(".e-col1 img")!.GetAttribute("title");
            decimal _cardPrice = 0; //decimal.Parse(store!.QuerySelector(".e-col1 img")!.GetAttribute("title")!.ToString().Trim());
            //TODO: A Ligamagic renderiza os números do preço como imagens, verificar forma de contornar isso
            //>> Ideia: renderizar uma única imagem a partir das divs dos números e tentar algum tipo de OCR
            _returnCard.Stores.Add(new StoreCard(_storeName!, _cardPrice));
        }

        return _returnCard;
    }
}