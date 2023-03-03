using AngleSharp;
using System.Web;
using System.Text.RegularExpressions;

namespace MagicCotador;

public class QuotationEngine
{
    string[] _storesLinksRepository = new string[] { "https://www.playgroundgames.com.br/" };
    public async Task<Card> GetCardData(string _cardName)
    {
        Card _returnCard = new Card(_cardName);

        int _cardCode = await GetCardCode(_cardName);

        //TODO: Executar busca na ligamagic e processar as lojas
        /*
        var config = Configuration.Default.WithDefaultLoader();
        using var context = BrowsingContext.New(config);
        using var doc = await context.OpenAsync("https://www.ligamagic.com.br/?view=cards/card&card=platinum%20angel");
        //cardName = doc.QuerySelector("p.nome-principal").GetAttribute("title");
        cardName = doc.DocumentElement.QuerySelector("p.nome-principal > span").InnerHtml;
        */

        /*
        
        Ideia nova:
        1) Pegar o código da carta no site da Ligamagic
        2) Criar um repositório de links das lojas
        3) Com o código da Ligamagic, varrer os links das lojas buscando os dados da carta
        4) Pegar todo o estoque da carta, verificar o menor preço com quantidade maior que zero   
        
        */

        return _returnCard;
    }

    private async Task<int> GetCardCode(string _cardName)
    {
        int _cardCode = 0;
        var config = Configuration.Default.WithDefaultLoader();
        using var context = BrowsingContext.New(config);
        using var doc = await context.OpenAsync("https://www.ligamagic.com.br/?view=cards/card&card=" + HttpUtility.UrlEncode(_cardName));

        _cardCode = Convert.ToInt32(doc.DocumentElement!.QuerySelector("button.mp-botao-comprar")!.GetAttribute("onclick")!.Replace("CarrinhoListaCompra.addItem(this, \"", "").Replace("\", \"\",\"\", \"#lc_buy_1\");", ""));

        return _cardCode;
    }

    private async Task<List<StockItem>> GetStores(int _cardCode)
    {
        List<StockItem> _stock = new List<StockItem>();

        var config = Configuration.Default.WithDefaultLoader();
        using var context = BrowsingContext.New(config);
        using var doc = await context.OpenAsync("https://www.playgroundgames.com.br/?view=ecom/item&card=" + _cardCode.ToString().Trim());

        return _stock;
    }
}