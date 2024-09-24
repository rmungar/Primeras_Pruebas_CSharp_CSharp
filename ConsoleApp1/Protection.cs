namespace ConsoleApp1;

public abstract class Protection : IItem
{
    private string _name;
    private int _armor;
    private Perks? _perk;

    public Protection(string name, int armor, Perks? perk)
    {
        _name = name;
        _armor = armor;
        _perk = perk;
    }
    
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
    

    public override string ToString()
    {
        if (_perk == null)
        {
            return GetName() + " - " + GetAmount() + " armor points" + " - " + "No Perk" ;
        }
        return GetName() + " - " + GetAmount() + " armor points" + " - " + "Perk: " + GetPerk();
    }
}