namespace ConsoleApp1;

public class Minion()
{

    private int _damage = Random.Shared.Next(0, 10);
    
    public int GetDamage()
    {
        return _damage;
    }
}