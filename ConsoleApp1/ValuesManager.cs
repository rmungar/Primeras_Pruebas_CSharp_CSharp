namespace ConsoleApp1;

public class ValuesManager
{

    public double GetTotalDamage(Character character)
    {
        double characterTotalDamage = character.GetBaseDamage();
        foreach (var item in character._inventory)
        {
            if (item is Weapon)
            {
                double additiveDamage = 0.0;
                if (item.GetPerk() == Perks.FIRE_EFFECT)
                {
                    additiveDamage = item.GetAmount() + (item.GetAmount() * 0.1);
                    characterTotalDamage += additiveDamage;
                }
                if (item.GetPerk() == Perks.TTA)
                {
                    additiveDamage = item.GetAmount() + (item.GetAmount() * 0.5);
                    characterTotalDamage += additiveDamage;
                }
            }
        }
        return characterTotalDamage;
    }

//--------------------------------------------------------------------------------------------------------------------//
    
    public double GetTotalDefense(Character character)
    {
        double characterTotalDefense = character.GetBaseArmor();
        foreach (var item in character._inventory)
        {
            if (item is Armor)
            {
                double additiveArmor = 0.0;
                if (item.GetPerk() == Perks.GUARD)
                {
                    additiveArmor = item.GetAmount() + (item.GetAmount() * 0.5);
                    characterTotalDefense += additiveArmor;
                }
            }
        }
        return characterTotalDefense;
    }
    
//--------------------------------------------------------------------------------------------------------------------//

    public double GetTotalHealing(int baseHealing, Character character)
    {
        double characterTotalHealing = baseHealing;
        foreach (var item in character._inventory)
        {
            if (item is Armor)
            {
                double additiveHealing = 0.0;
                if (item.GetPerk() == Perks.HEALING)
                {
                    additiveHealing = (characterTotalHealing * 0.15);
                    characterTotalHealing += additiveHealing;
                }
            }
        }
        return characterTotalHealing;
    }
    
//--------------------------------------------------------------------------------------------------------------------//


    
}