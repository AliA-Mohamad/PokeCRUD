using Newtonsoft.Json;
using PokeCRUD.Models;

namespace PokeCRUD.Services;

internal class PokeAPIService
{
    public static async Task<PokeData> GetRandomPokemon()
    {
        using (HttpClient client = new())
        {
            try
            {
                Random random = new();
                string key = $"https://pokeapi.co/api/v2/pokemon/{random.Next(0, 1011)}";
                HttpResponseMessage response = await client.GetAsync(key);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    PokeData pokemon = JsonConvert.DeserializeObject<PokeData>(responseBody);
                    return pokemon;
                }
                else
                {
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
