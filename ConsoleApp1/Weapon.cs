namespace ConsoleApp1;

public abstract class Weapon : IItem
{
    private string _name;
    private int _damage;
    private Perks? _perk;
    
    public Weapon(string name, int damage, Perks? perk)
    {
        _name = name;
        _damage = damage;
        _perk = perk;
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
    
    public void Apply(Character character)
    {
        character._inventory.Add(this);
    }
    
    public override string ToString()
    {
        if (_perk == null)
        {
            return GetName() + " - " + GetAmount() + " damage points" + " - " + "No Perk" ;
        }
        return GetName() + " - " + GetAmount() + " damage points" + " - " + "Perk: " + GetPerk();
        
    }
}