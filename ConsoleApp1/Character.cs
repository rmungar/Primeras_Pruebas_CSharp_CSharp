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
        
        // Comprobaciones de los valores ingresados en el construcutor.
        _name = name;
        _maxHitPoints = _maxHitPoints < 0 ? 100 : maxHitPoints;
        _baseArmor = _baseArmor < 0 ? 0 : baseArmor;
        _baseDamage = _baseDamage < 0 ? 10 : baseDamage;
        _currentHp = _maxHitPoints;
    }


// Devuelve el nombre del personaje
    
    public string GetName()
    {
        return _name;
    }
    
//--------------------------------------------------------------------------------------------------------------------//    
    
// Devuelve el daño base del personaje

    public int GetBaseDamage()
    {
        return _baseDamage;
    }

//--------------------------------------------------------------------------------------------------------------------//
    
// Devuelve la armadura base del personaje

    public int GetBaseArmor()
    {
        return _baseArmor; 
    }

//--------------------------------------------------------------------------------------------------------------------//

// Hace atacar al personaje, devuelve el ataque total de esste.

    public double Attack()
    {
        return ValuesManager.GetTotalDamage(this);
    }
    
//--------------------------------------------------------------------------------------------------------------------//    
    
// Hace defender al personaje, devuelve la defensa total de este.

    public double Defense()
    {
        return ValuesManager.GetTotalDefense(this);
    }
  
//--------------------------------------------------------------------------------------------------------------------//

// Después de calcular la curación total, comprueba los valores y cura al personaje en función de dichas comprobaciones.

    public double Heal(int amount)
    {
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
    
//--------------------------------------------------------------------------------------------------------------------//    
    
// Modifica la vida actual del personaje en función del valor del parámetro.

    public double RecieveDamage(int damage)
    {
        var characterDefense = ValuesManager.GetTotalDefense(this);
        if (characterDefense <= damage)
        {
         _currentHp -= (damage - characterDefense);
         return _maxHitPoints - _currentHp;
        }

        return 0.0;
    }

//--------------------------------------------------------------------------------------------------------------------//    
    
// Muestra por pantalla el inventario del personaje

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



    public void AddToInventory(IItem item)
    {
        _inventory.Add(item);
    }
    
}
