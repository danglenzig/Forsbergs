namespace CharacterCustomization_V1;

public class Warrior : Character
{

    private string weaponNomenclature;

    public string WeaponNomenclature
    {
        get => weaponNomenclature;
        set
        {
            weaponNomenclature = value;
        }
    }

    public Warrior(string name, int health, int level, int attackDamage, int blockValue, int healValue, string _weaponNomenclature) : base(name,
        health, level, attackDamage, blockValue, healValue)
    {
        WeaponNomenclature = _weaponNomenclature;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"    Character type: Warrior, Weapon: {WeaponNomenclature}");
    }

    public override void Attack(Character targetCharacter)
    {
        Console.WriteLine($"*** Warrior {Name} attacks {targetCharacter.Name} with {WeaponNomenclature} ***");
        base.Attack(targetCharacter);
    }
}