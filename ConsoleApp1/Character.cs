namespace ConsoleApp1;

public class Character {
    private string _name ;
    private int _maxHitPoints;
    private int _currentHp;
    private int _baseArmor;
    private int _baseDamage;
    public List<IItem> _inventory = [];

    public Character(string name, int maxHitPoints, int baseArmor, int baseDamage)
    {
        _name = name;
        _maxHitPoints = _maxHitPoints < 0 ? 100 : maxHitPoints;
        _baseArmor = _baseArmor < 0 ? 0 : baseArmor;
        _baseDamage = _baseDamage < 0 ? 10 : baseDamage;
        _currentHp = _maxHitPoints;
    }
    
    
    
}
