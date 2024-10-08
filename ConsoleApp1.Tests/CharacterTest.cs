using System.Linq;
using ConsoleApp1.various;
using ConsoleApp1.weapon;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1.Tests;

[TestClass]
[TestSubject(typeof(Character))]
public class CharacterTest
{

    [TestMethod]
    public void Method()
    {
        Character character = new Character("tset");
        Weapon testwp1 = new Sword("EX", 40, Perks.Tta, false);
        Weapon testwp2 = new Axe("AX", 30, Perks.FireEffect, true);
        
        character.AddToInventory(testwp1);
        character.AddToInventory(testwp2);
        
        character.SpawnMinions();
        
        Assert.AreEqual(1, character.GetMinions().Count());
    }
}