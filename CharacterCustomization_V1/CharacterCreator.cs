namespace CharacterCustomization_V1;

public class CharacterCreator
{
    
    private EncounterManager encounterManager;
    
    //private Character character01;
    //private Character character02;
    //private Character character03;
    //private Character character04;
    
    //private List<Character> characters = new List<Character>();
    
    public CharacterCreator(EncounterManager _encounterManager)
    {
        encounterManager = _encounterManager;
    }
    
    public void StartCharacterCreation()
    {
        Console.Clear();
        for (int i = 0; i < 4; i++)
        {
            Console.Clear();
            Console.WriteLine($"Character number {i + 1}:");
            string name = "";
            Console.Write("Name: ");
            name = Console.ReadLine();

            int classInt = -1;
            EnumClassType classType = EnumClassType.NONE;
            while (classInt < 1 || classInt > 2)
            {
                Console.Clear();
                Console.WriteLine($"{name}'s Character class...");
                Console.WriteLine("1) Warrior");
                Console.WriteLine("2) Mage");
                Console.Write(": ");
                classInt = Convert.ToInt32(Console.ReadLine());
                if (classInt == 1)
                {
                    classType = EnumClassType.WARRIOR;
                }
                else if (classInt == 2)
                {
                    classType = EnumClassType.MAGE;
                }
            }

            Console.Clear();
            int health = -1;
            Console.Write($"{name}'s starting health: ");
            health = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();
            int level = -1;
            Console.Write($"{name}'s starting level: ");
            level = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();
            int attackDamage = -1;
            Console.Write($"{name}'s attack damage: ");
            attackDamage =  Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();
            int blockValue = -1;
            Console.Write($"{name}'s block value: ");
            blockValue = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();
            int healValue = -1;
            Console.Write($"{name}'s heal value: ");
            healValue = Convert.ToInt32(Console.ReadLine());

            switch (classType)
            {
                case EnumClassType.WARRIOR:
                    Console.Clear();
                    string weaponName = "";
                    Console.Write($"{name}'s weapon name: ");
                    weaponName = Console.ReadLine();
                    
                    // create warrior with data
                    Warrior warrior = new Warrior(name, health, level,attackDamage,blockValue,healValue,weaponName);
                    if (i < 2)
                    {
                        encounterManager.AddCharacterToTeam(warrior, EncounterManager.EnumTeam.TEAM_A);
                    }
                    else
                    {
                        encounterManager.AddCharacterToTeam(warrior, EncounterManager.EnumTeam.TEAM_B);
                    }
                    break;
                
                case EnumClassType.MAGE:
                    Console.Clear();
                    string spellName = "";
                    Console.Write($"{name}'s spell name: ");
                    spellName = Console.ReadLine();
                    
                    // create mage with data
                    Mage mage = new Mage(name, health, level,attackDamage, blockValue, healValue, spellName);
                    if (i < 2)
                    {
                        encounterManager.AddCharacterToTeam(mage, EncounterManager.EnumTeam.TEAM_A);
                    }
                    else
                    {
                        encounterManager.AddCharacterToTeam(mage, EncounterManager.EnumTeam.TEAM_B);
                    }
                    break;
            }
        }
    }
}