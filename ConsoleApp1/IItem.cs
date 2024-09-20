using System.Runtime.InteropServices.JavaScript;

namespace ConsoleApp1;

public interface IItem
{
    
    public void Apply(Character character)
    {
        
    }

    public double GetAmount()
    {
        return 0;
    }


    public Perks? GetPerk()
    {
        return null;
    }

    
}