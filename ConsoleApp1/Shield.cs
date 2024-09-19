namespace ConsoleApp1;

public class Shield(string name, int armor, Perks? perk) : Protection
{
    private string _name = name;
    private int _armor = armor;
    private Perks? _perk = perk;
}
