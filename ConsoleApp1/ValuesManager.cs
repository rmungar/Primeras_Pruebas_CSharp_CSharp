namespace ConsoleApp1;

public class ValuesManager
{
    /**
        Funcion encargada de calcular y devolver el daño total que realiza el personaje despues de aplicar todos los 
        posibles modificadores (Perks).
    */
    public static double GetTotalDamage(Character character)
    {
        // Variable que contiene el valor del daño base del personaje antes de aplicar los modificadores.
        double characterTotalDamage = character.GetBaseDamage();
        foreach (var item in character._inventory)
        {
           
            if (item is Weapon weapon)
            {
                double additiveDamage;
                if (weapon.GetPerk() == Perks.FIRE_EFFECT) {
                    additiveDamage = (weapon.GetAmount() + (weapon.GetAmount() * 0.1))!;
                    characterTotalDamage += additiveDamage;
                }
                if (weapon.GetPerk() == Perks.TTA) {
                    additiveDamage = (weapon.GetAmount() + (weapon.GetAmount() * 0.5))!;
                    characterTotalDamage += additiveDamage;
                }
            }
        }
        return characterTotalDamage;
    }

//--------------------------------------------------------------------------------------------------------------------//
    
    /**
        Funcion encargada de calcular y devolver la defensa total que realiza el personaje despues de aplicar todos los 
        posibles modificadores (Perks).
    */
    public static double GetTotalDefense(Character character)
    {
        // Variable que contiene el valor del daño base del personaje antes de aplicar los modificadores.
        double characterTotalDefense = character.GetBaseArmor();
        foreach (var item in character._inventory)
        {
            if (item.GetPerk() == Perks.GUARD)
            {
                var additiveArmor = (item.GetAmount() + (item.GetAmount() * 0.5))!;
                characterTotalDefense += additiveArmor;
            }
        }
        return characterTotalDefense;
    }
    
//--------------------------------------------------------------------------------------------------------------------//

    /**
        Funcion encargada de calcular y devolver la cantidad de vida que se tiene que curar el personaje.
    */
    public static double GetTotalHealing(int baseHealing, Character character)
    {
        double characterTotalHealing = baseHealing;
        foreach (var item in character._inventory)
        {
            if (item is Armor armor)
            {
                if (armor.GetPerk() == Perks.HEALING)
                {
                    var additiveHealing = (characterTotalHealing * 0.15);
                    characterTotalHealing += additiveHealing;
                }
            }
        }
        return characterTotalHealing;
    }
    
}