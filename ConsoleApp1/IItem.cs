using System.Runtime.InteropServices.JavaScript;

namespace ConsoleApp1;

public interface IItem
{
    int amAlmunt;
    
    public void Apply(Character character) {}

    public int GetAmount()
    {
        this;
    }


    public Perks? GetPerk()
    {
        return null;
    }

    public string ToString()
    {
        return "";
    }
}