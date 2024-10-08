namespace ConsoleApp1;

public abstract class Weapon : IItem
{
    private string _name;
    private int _damage;
    private Perks? _perk;
    private bool _minion;
    
    public Weapon(string name, int damage, Perks? perk, bool minion)
    {
        _name = name;
        _damage = damage;
        _perk = perk;
        _minion = minion;
    }
    
    public string GetName()
    {
        return _name;
    }

    public int GetAmount()
    {
        return _damage;
    }

    public Perks? GetPerk()
    {
        return _perk ?? null;
    }
    
    
    public override string ToString()
    {
        if (_perk == null)
        {
            return GetName() + " - " + GetAmount() + " damage points" + " - " + "No Perk" ;
        }
        return GetName() + " - " + GetAmount() + " damage points" + " - " + "Perk: " + GetPerk();
        
    }


    public bool GetMinion()
    {
        return _minion;
    }
}