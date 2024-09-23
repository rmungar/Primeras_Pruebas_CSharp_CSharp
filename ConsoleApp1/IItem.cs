using System.Runtime.InteropServices.JavaScript;

namespace ConsoleApp1;

public interface IItem
{
    
    public void Apply(Character character){}

    
//--------------------------------------------------------------------------------------------------------------------//

// Devuelve bien sea, la armadura de un item como el daño. En funcion de si es un arma o un elemento de protección.
    
    public double GetAmount()
    {
        return 0;
    }

//--------------------------------------------------------------------------------------------------------------------//

// Devuelve la perk del item, o un nulo.

    public Perks? GetPerk()
    {
        return null;
    }

    
}