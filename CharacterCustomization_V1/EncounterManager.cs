namespace CharacterCustomization_V1;

public class EncounterManager
{
    
    public enum EnumTeam {TEAM_A, TEAM_B}
    
    private List<Character> teamA = new List<Character>();
    private List<Character> teamB = new List<Character>();
    
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

    public void StartFighing()
    {
        Character attackingCharacter = teamA[0];
        Character targetCharacter = teamB[0];
        attackingCharacter.Attack(targetCharacter);
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

    public void ShowTeamInfo(EnumTeam team)
    {
        
        //Console.WriteLine($"Team A size: {teamA.Count}");
        //Console.WriteLine($"Team B size: {teamB.Count}");
        
        
        
        
        switch (team)
        {
            case EnumTeam.TEAM_A:
                foreach (Character character in teamA)
                {
                    Console.WriteLine(character.Name+":");
                    character.ShowInfo();
                }
                break;
            case EnumTeam.TEAM_B:
                foreach (Character character in teamB)
                {
                    Console.WriteLine(character.Name+":");
                    character.ShowInfo();
                }
                break;
        }
        
        Console.WriteLine();
    }
    
}