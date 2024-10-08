namespace ConsoleApp1;

public abstract class Protection : IItem
{
    private string _name;
    private int _armor;
    private Perks? _perk;
    private bool _minion;

    public Protection(string name, int armor, Perks? perk, bool minion)
    {
        _name = name;
        _armor = armor;
        _perk = perk;
        _minion = minion;
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


    public bool GetMinion()
    {
        return _minion;
    }
}