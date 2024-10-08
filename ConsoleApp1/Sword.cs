namespace ConsoleApp1;

public class Sword(string name, int damage, Perks? perk, bool minion) : Weapon(name, damage, perk, minion)
{
    private string _name = name;
    private int _damage = damage;
    private Perks? _perk = perk;
    private bool _minion = minion;
    

    public override string ToString()
    {
        if (_perk == null)
        {
            return _name + " - " + _damage + " damage points" + " - " + "No Perk" ;
        }
        return _name + " - " + _damage + " damage points" + " - " + "Perk: " + _perk;
        
    }
}