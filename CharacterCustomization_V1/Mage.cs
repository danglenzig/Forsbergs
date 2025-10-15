namespace CharacterCustomization_V1;

public class Mage : Character
{
    private string spellNomenclature;
    public string SpellNomenclature
    {
        get => spellNomenclature;
        set
        {
            spellNomenclature = value;
        }
    }
    
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"    Character type: Mage, Spell: {SpellNomenclature}");
    }
    
    public Mage(string name, int health, int level, int attackDamage, int blockValue, int healValue, string _spellNomenclature) : base(name,
        health, level, attackDamage, blockValue, healValue)
    {
        SpellNomenclature = _spellNomenclature;
    }
    
    public override void Attack(Character targetCharacter)
    {
        Console.WriteLine($"*** Mage {Name} attacks {targetCharacter.Name} with {SpellNomenclature} ***");
        base.Attack(targetCharacter);
    }
    
}