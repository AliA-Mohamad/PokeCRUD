namespace PokeCRUD.Services;

internal class PokeData
{
    public string name { get; set; }
}

internal class PokeAPIService
{
    public static async Task<PokeData> PokemonAPIConection()
    {
        using (HttpClient client = new())
        {
            try{
                HttpResponseMessage response = await client.GetAsync("https://pokeapi.co/api/v2/pokemon/1");
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    PokeData pokemon = Newtonsoft.Json.JsonConvert.DeserializeObject<PokeData>(responseBody);
                    return pokemon;
                }
                else
                {
                    Console.WriteLine("Erro ao fazer a requisição à API. Código de status: " + response.StatusCode);
                    return null;
                }

                }
            catch (Exception ex) {
                Console.WriteLine("Erro: " + ex.Message);
                return null;
            }
            
        }
    }
}
