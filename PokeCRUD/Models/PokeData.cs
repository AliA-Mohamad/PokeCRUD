namespace PokeCRUD.Models;

public class PokeData
{
    public string Name { get; set; }
    public Sprites sprites { get; set; }

}

public class Sprites
{
    public string front_default { get; set; }
}