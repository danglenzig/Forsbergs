namespace CharacterCustomization_V1;

public class EncounterManager
{
    
    public enum EnumTeam {TEAM_A, TEAM_B}
    
    private List<Character> teamA = new List<Character>();
    private List<Character> teamB = new List<Character>();
    
    //private Character activeCharacter = null;
    
    private int teamATurnIdx = -1;
    private int teamBTurnIdx = -1;
    
    private EnumTeam activeTeam = EnumTeam.TEAM_A;

    public void AddCharacterToTeam(Character character, EnumTeam team)
    {
        if (team == EnumTeam.TEAM_A)
        {
            teamA.Add(character);
        }
        else
        {
            teamB.Add(character);
        }
    }

    public void TakeTurnRoutine()
    {

        Character activeCharacter = null;
        
        int teamSize = -1;
        if (activeTeam == EnumTeam.TEAM_A)
        {
            teamATurnIdx++;
            teamSize = teamA.Count;
            int pickIdx = teamATurnIdx %  teamSize;
            activeCharacter = teamA[pickIdx];
        }
        else
        {
            teamBTurnIdx++;
            teamSize = teamB.Count;
            int pickIdx = teamBTurnIdx %  teamSize;
        }
        
        Console.WriteLine($"{activeCharacter.Name}'s turn.");
        Console.WriteLine($"{activeCharacter.Name}'s current status:");
        activeCharacter.ShowInfo();
        
        Console.WriteLine($"Does {activeCharacter.Name} attack, block., or heal?");
        Console.WriteLine("1) Attack");
        Console.WriteLine("2) Block");
        Console.WriteLine("3) Heal");
       
        int choice = -1;
        while (choice < 1 || choice >= 3)
        {
            Console.Write("Enter a number->");
            choice = Convert.ToInt32(Console.ReadLine());
        }

        switch (choice)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
        }
        
        
    }
}