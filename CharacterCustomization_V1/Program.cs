namespace CharacterCustomization_V1;
class Program
{
    
    
    
    static void Main(string[] args)
    {
        
        EncounterManager encounterManager = new EncounterManager();
        
        Warrior bob = new Warrior("Bob", 100, 1, 12, 6, 4, "Mop");
        Warrior alice = new Warrior("Alice", 100, 1, 12, 6, 4, "Stapler");
        Mage corky = new Mage("Corky", 100, 1, 10, 3, 6, "Devastating Angry Note");
        Mage simon = new Mage("Simon", 100, 1, 10, 3, 6, "Bad Attitude");
        
        encounterManager.AddCharacterToTeam(bob, EncounterManager.EnumTeam.TEAM_A);
        encounterManager.AddCharacterToTeam(corky, EncounterManager.EnumTeam.TEAM_A);
        encounterManager.AddCharacterToTeam(simon, EncounterManager.EnumTeam.TEAM_B);
        encounterManager.AddCharacterToTeam(alice, EncounterManager.EnumTeam.TEAM_B);
        
    }
}
