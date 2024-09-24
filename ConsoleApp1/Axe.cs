namespace ConsoleApp1;

public class Axe(string name, int damage, Perks? perk) : Weapon(name, damage, perk)
{
    private string _name = name;
    private int _damage = damage;
    private Perks? _perk = perk;
    
    
    
    public override string ToString()
    {
        if (_perk == null)
        {
            return _name + " - " + _damage + " damage points" + " - " + "No Perk" ;
        }
        return _name + " - " + _damage + " damage points" + " - " + "Perk: " + _perk;
        
    }
    
}