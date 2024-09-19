using ConsoleApp1;

    Character character = new Character("1");

    Weapon wp1 = new Sword("EX", 40, Perks.TTA);
    Weapon wp2 = new Axe("AX", 30, Perks.FIRE_EFFECT);

    Protection pr1 = new Shield("SH", 50, Perks.HEALING);
    Protection pr2 = new Shield("AR", 30, Perks.GUARD);

    wp1.Apply(character);
    wp2.Apply(character);
    pr1.Apply(character);
    pr2.Apply(character);

    Console.WriteLine(character.GetName() + " dealt " + character.Attack() + " damage " + "to an enemy.");
    Console.WriteLine(character.GetName() + " has " + character.Defense() + " points of armor.");
    Console.WriteLine(character.GetName() + " recieved " + character.RecieveDamage(32) + " points of damage.");
    Console.WriteLine(character.GetName() + " has healed " + character.Heal(100) + " health points.");

    character.ShowInventory();


 