namespace ConsoleApp1;

public class Armor(string name, int armor, Perks? perk) : Protection
{
    private string _name = name;
    private int _armor = armor;
    private Perks? _perk = perk;
    
    public override string ToString()
    {
        if (_perk == null)
        {
            return _name + " - " + _armor + " armor points" + " - " + "No Perk" ;
        }
        return _name + " - " + _armor + " armor points" + " - " + "Perk: " + _perk;
        
    }
}