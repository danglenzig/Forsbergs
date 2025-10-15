namespace CharacterCustomization_V1;

public class Character : IAttackable, IDefendable, IHealable
{
    private const int maxHealth = 100;
    
    private const int maxLevel = 100;
    private const int minLevel = 1;

    private const int maxAttackDamage = 15;
    
    private const int maxBlock = 12;
    private const int maxHealAmount = 12;


    private string name;
    public string Name
    {
        get => name;
        set
        {
            name = value;
        }
    }
    
    private int health;
    public int Health
    {
        get => health;
        set
        {
            if (value > maxHealth)
            {
                health = maxHealth;
            }
            else
            {
                health = value;
            }
        }
    }

    private int level;
    public int Level
    {
        get => level;
        set
        {
            if (value < minLevel)
            {
                level = minLevel;
            }
            else if (value > maxLevel)
            {
                level = maxLevel;
            }
            else
            {
                level = value;
            }
        }
    }

    private int attackDamage;
    public int AttackDamage
    {
        get => attackDamage;
        set
        {
            if (value > maxAttackDamage)
            {
                attackDamage = maxAttackDamage;
            }
            else if (value < 0)
            {
                attackDamage = 0;
            }
            else
            {
                attackDamage = value;
            }
        }
    }
    
    private int blockValue;
    public int BlockValue
    {
        get => blockValue;
        set
        {
            if (value > maxBlock)
            {
                blockValue = maxBlock;
            }
            else if (value < 0)
            {
                blockValue = 0;
            }
            else
            {
                blockValue = value;
            }
        }
    }
    
    private int healValue;
    public int HealValue
    {
        get => healValue;
        set
        {
            if (value > maxHealAmount)
            {
                healValue = maxHealAmount;
            }
            else if (value < 0)
            {
                healValue = 0;
            }
            else
            {
                healValue = value;
            }
        }
    }

    private bool isBlocking;
    public bool IsBlocking
    {
        get => isBlocking;
        set
        {
            isBlocking = value;
        }
    }

    public Character(string _name, int _health, int _level, int _attackDamage, int _blockValue, int _healValue)
    {
        isBlocking = false;
        Name = _name;
        Health = _health;
        Level = _level;
        AttackDamage = _attackDamage;
        BlockValue = _blockValue;
        HealValue = _healValue;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"    Name: {Name}, Health: {Health}, Level: {Level}");
    }

    public virtual void Attack(Character targetCharacter)
    {
        int targetCurrentHealth = targetCharacter.Health;
        bool targetIsBlocking = targetCharacter.IsBlocking;
        int damageThisAttack = AttackDamage;
        if (targetIsBlocking)
        {
            damageThisAttack -= targetCharacter.blockValue;
            targetCharacter.isBlocking = false;
        }

        if (targetCurrentHealth - damageThisAttack <= 0)
        {
            targetCharacter.Health = 0;
        }
        else
        {
            targetCharacter.Health -= damageThisAttack;
        }
        
        Console.WriteLine($"{targetCharacter.Name} is blocking: {targetCharacter.IsBlocking}");
        Console.WriteLine($"{targetCharacter.Name}'s healthis now: {targetCharacter.Health}");
        Console.WriteLine($"{targetCharacter.Name}'s current status: ");
        targetCharacter.ShowInfo();
        
        
    }

    public virtual void Defend()
    {
        IsBlocking = true;
    }

    public virtual void Heal()
    {
        int newHealth = Health + HealValue;
        if (newHealth > maxHealth)
        {
            Health = maxHealth;
        }
        else
        {
            Health = newHealth;
        }
    }
}