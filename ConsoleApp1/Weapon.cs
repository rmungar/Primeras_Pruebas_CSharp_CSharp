namespace ConsoleApp1;

public abstract class Weapon : IItem
{
    private string _name;
    private int _damage;
    private Perks? _perk;

    
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
            return _name + " - " + _damage + " damage points" + " - " + "No Perk" ;
        }
        return _name + " - " + _damage + " damage points" + " - " + "Perk: " + _perk;
    }
}