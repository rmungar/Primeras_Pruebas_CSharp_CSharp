namespace ConsoleApp1;

public class ValuesManager
{

    public static double GetTotalDamage(Character character)
    {
        double characterTotalDamage = character.GetBaseDamage();
        foreach (var item in character._inventory)
        {
            if (item is Weapon weapon)
            {
                double additiveDamage;
                if (weapon.GetPerk() == Perks.FIRE_EFFECT)
                {
                    additiveDamage = (weapon.GetAmount() + (weapon.GetAmount() * 0.1))!;
                    characterTotalDamage += additiveDamage;
                }
                if (weapon.GetPerk() == Perks.TTA)
                {
                    additiveDamage = (weapon.GetAmount() + (weapon.GetAmount() * 0.5))!;
                    characterTotalDamage += additiveDamage;
                }
            }
        }
        return characterTotalDamage;
    }

//--------------------------------------------------------------------------------------------------------------------//
    
    public static double GetTotalDefense(Character character)
    {
        double characterTotalDefense = character.GetBaseArmor();
        foreach (var item in character._inventory)
        {
            if (item is Protection protection)
            {
                if (protection.GetPerk() == Perks.GUARD)
                {
                    var additiveArmor = (protection.GetAmount() + (protection.GetAmount() * 0.5))!;
                    characterTotalDefense += additiveArmor;
                }
            }
        }
        return characterTotalDefense;
    }
    
//--------------------------------------------------------------------------------------------------------------------//

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