using System.Runtime.InteropServices.JavaScript;

namespace ConsoleApp1;

public interface IItem
{
    public void Apply(Character character)
    {
        character._inventory.Add(this);
    }

    public void ToString()
    {
        Console.WriteLine(base.ToString());
    }
}