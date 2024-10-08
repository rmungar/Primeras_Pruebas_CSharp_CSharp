using ConsoleApp1;
using ConsoleApp1.protection;
using ConsoleApp1.various;
using ConsoleApp1.weapon;

Character character = new Character("1");

    Weapon wp1 = new Sword("EX", 40, Perks.Tta, false);
    Weapon wp2 = new Axe("AX", 30, Perks.FireEffect, true);

    Protection pr1 = new Shield("SH", 50, Perks.Healing, true);
    Protection pr2 = new Shield("AR", 30, Perks.Guard, false);

    character.AddToInventory(wp1);
    character.AddToInventory(wp2);
    character.AddToInventory(pr1);
    character.AddToInventory(pr2);

    Console.WriteLine(character.GetName() + " dealt " + character.Attack() + " damage " + "to an enemy.");
    Console.WriteLine(character.GetName() + " has " + character.Defense() + " points of armor.");
    Console.WriteLine(character.GetName() + " received " + character.RecieveDamage(32) + " points of damage.");
    Console.WriteLine(character.GetName() + " has healed " + character.Heal(100) + " health points.");

    character.ShowInventory();
    
    character.SpawnMinions();


 