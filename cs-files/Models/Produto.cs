using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ContosoCraft.Models;

// {
//     "id" : "vogueandcode-pretty-girls-code-tee",
//     "maker" : "vogueandcode",
//     "img" : "https://user-images.githubusercontent.com/41929050/61567062-14c4b300-aa33-11e9-9dcd-8bfed4ece810.png",
//     "url" : "https://www.vogueandcode.com/shop/pretty-girls-code-tee",
//     "title" : "Pretty Girls Code Tee",
//     "description" : "Everyone’s favorite design is finally here on a tee! The Pretty Girls Code crew-neck tee is available in a soft pink with red writing."
// },

public class Produto
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("maker")]
    public string Maker { get; set; } = string.Empty;

    [JsonPropertyName("img")]
    public string Imagem { get; set; } = string.Empty;

    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;

    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;
    public int[] Rating { get; set; } = new int[5];

    /* 
        Polimorfismo no método ToString para tornar os objetos no formato JSON
        Reescrever o método ToString é importante para retornar representações
        mais legíveis de objetos
        Nesse caso, será serializando os objetos para o JSON
        Mas poderia ser uma simples string de retorno, por exemplo:
            
            public override string ToString() => $"Id : {id}; Maker: {Maker}"
    */
    public override string ToString() => JsonSerializer.Serialize<Produto>(this);

}