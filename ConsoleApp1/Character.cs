namespace ConsoleApp1;

public class Character {
    private string _name ;
    private int _maxHitPoints;
    private double _currentHp;
    private int _baseArmor;
    private int _baseDamage;
    public List<IItem> _inventory = [];

    public Character(string name, int maxHitPoints = 100, int baseArmor = 0, int baseDamage = 10)
    {
        _name = name;
        _maxHitPoints = _maxHitPoints < 0 ? 100 : maxHitPoints;
        _baseArmor = _baseArmor < 0 ? 0 : baseArmor;
        _baseDamage = _baseDamage < 0 ? 10 : baseDamage;
        _currentHp = _maxHitPoints;
    }


    public string GetName()
    {
        return _name;
    }
    
    
    public int GetBaseDamage()
    {
        return _baseDamage;
    }

    public int GetBaseArmor()
    {
        return _baseArmor; 
    }


    public double Attack()
    {
        var valuesManager = new ValuesManager();
        return ValuesManager.GetTotalDamage(this);
    }
    
    public double Defense()
    {
        var valuesManager = new ValuesManager();
        return ValuesManager.GetTotalDefense(this);
    }
    
    public double Heal(int amount)
    {
        var valuesManager = new ValuesManager();
        var toHeal = ValuesManager.GetTotalHealing(amount, this);
        var healed = 0.0;
        if (toHeal >= _maxHitPoints)
        {
            healed = _maxHitPoints - _currentHp;
            _currentHp = _maxHitPoints;
        }
        else
        {
            if (_currentHp + toHeal > _maxHitPoints)
            {
                healed = _maxHitPoints - _currentHp;
                _currentHp = _maxHitPoints;
            }
            else
            {
                _currentHp += toHeal;
                healed = toHeal;
            }
        }
        return healed;
    }
    
    
    public double RecieveDamage(int damage)
    {
        var valuesManager = new ValuesManager();
        var characterDefense = ValuesManager.GetTotalDefense(this);
        if (characterDefense <= damage)
        {
         _currentHp -= (damage - characterDefense);
         return _maxHitPoints - _currentHp;
        }

        return 0.0;
    }

    public void ShowInventory()
    {
        Console.WriteLine();
        Console.WriteLine("-- INVENTORY --");
        Console.WriteLine();
        foreach (var item in _inventory)
        {
            Console.WriteLine(item.ToString());
        }
    }
}
