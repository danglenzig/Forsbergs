namespace CharacterCustomization_V1;
class Program
{
    
    static void Main(string[] args)
    {
        
        
        
        
        
        
        EncounterManager encounterManager = new EncounterManager();
        CharacterCreator characterCreator = new CharacterCreator(encounterManager);
        RunGame();



        void RunGame()
        {
            
            
            
            characterCreator.StartCharacterCreation();
            
            Console.Clear();
            Console.WriteLine("Team A:");
            encounterManager.ShowTeamInfo(EncounterManager.EnumTeam.TEAM_A);
            Console.ReadKey();
            
            Console.Clear();
            Console.WriteLine("Team B:");
            encounterManager.ShowTeamInfo(EncounterManager.EnumTeam.TEAM_B);
            Console.ReadKey();
            
            Console.Clear();
            encounterManager.StartFighing();
            
            
        }
        
        
    }
}
