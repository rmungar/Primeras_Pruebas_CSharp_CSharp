namespace ConsoleApp1;

public abstract class Protection : IItem
{
    private string _name;
    private int _armor;
    private Perks? _perk;
    
    
    public string GetName()
    {
        return _name;
    }
    
    public int GetAmount()
    {
        return _armor;
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
            return GetName() + " - " + GetAmount() + " armor points" + " - " + "No Perk" ;
        }
        return GetName() + " - " + GetAmount() + " armor points" + " - " + "Perk: " + GetPerk();
    }
}