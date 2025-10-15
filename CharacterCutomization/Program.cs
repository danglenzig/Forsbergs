namespace CharacterCustomization
{

    interface IAttackable
    {
        void Attack(Character targetCharacter);
    }

    interface IDefendable
    {
        void Defend();
    }

    interface IHealable
    {
        void Heal();
    }
    
    public class Character: IAttackable, IDefendable, IHealable
    {

        private int maxHealth = 100;
        
        private string name;
        public string Name
        {
            get => name;
            private set
            {
                name = value;
            }
        }
        
        private int health;
        public int Health
        {
            get => health;
            private set
            {
                health = value;
            }
        }
        
        private int level;
        public int Level
        {
            get => level;
            private set
            {
                level = value;
            }
        }

        private int attackDamage;
        public int AttackDamage
        {
            get => attackDamage;
            set
            {
                if (value < 0)
                {
                    attackDamage = 0;
                }
                else
                {
                    attackDamage = value;
                }
            }
        }

        private int defendStrength;
        public int DefendStrength
        {
            get => defendStrength;
            set
            {
                if (value < 0)
                {
                    defendStrength = 0;
                }
                else
                {
                    defendStrength = value;
                }
            }
        }
        
        private int healAmount;
        public int HealAmount
        {
            get => healAmount;
            set
            {
                if (value < 0)
                {
                    healAmount = 0;
                }
                else
                {
                    healAmount = value;
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
        

        public Character(string _name, int _health, int _level, int _attackDamage, int _defendStrength, int _healAmount)
        {
            isBlocking = false;
            Name = _name;
            Health = _health;
            Level = _level;
            AttackDamage = _attackDamage;
            DefendStrength = _defendStrength;
            HealAmount = _healAmount;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"\nName: {Name}, Health: {Health}, Level: {Level}");
        }

        public virtual void Attack(Character targetCharacter)
        {
            int targetCurrentHealth = targetCharacter.Health;
            bool targetIsBlocking = targetCharacter.IsBlocking;
            int damageThisAttack = AttackDamage;
            if (targetIsBlocking)
            {
                // reduce the effective attack damage and release the block
                damageThisAttack -= targetCharacter.DefendStrength;
                targetCharacter.IsBlocking = false;
            }

            if (targetCurrentHealth - damageThisAttack <= 0)
            {
                targetCharacter.Health = 0;
            }
            else
            {
                targetCharacter.Health -= damageThisAttack;
            }
        }

        public void Defend()
        {
            IsBlocking = true;
        }

        public void Heal()
        {
            int newHealth = Health + HealAmount;
            if (newHealth >= maxHealth)
            {
                Health = maxHealth;
            }
            else
            {
                Health = newHealth;
            }
        }
        
        
        
    }

    public class Warrior : Character
    {
        private string weapon;
        public string Weapon
        {
            get => weapon;
            private set
            {
                weapon = value;
            }
        }
        public Warrior(string name, int health, int level, int attackDamage, int defendStrength, int healAmount, string _weapon) : base(name, health, level,attackDamage, defendStrength, healAmount)
        {
            Weapon = _weapon;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Character type: Warrior, Weapon: {Weapon}");
        }

        public override void Attack(Character targetCharacter)
        {
            base.Attack(targetCharacter);
            Console.WriteLine("\n---------------------------------------------------");
            Console.WriteLine($"Warrior {Name} attacks {targetCharacter.Name} with {Weapon}");
            Console.WriteLine($"{targetCharacter.Name} is blocking: {targetCharacter.IsBlocking}");
            Console.WriteLine($"{targetCharacter.Name} is health is now: {targetCharacter.Health}");
            Console.WriteLine($"{targetCharacter.Name} current status:");
            targetCharacter.ShowInfo();
        }
    }

    public class Mage : Character
    {
        private string attackSpell;
        public string AttackSpell
        {
            get => attackSpell;
            set
            {
                attackSpell = value;
            }
        }

        public Mage(string name, int health, int level, int attackDamage, int defendStrength, int healamount, string _attackSpell) : base(name,health,level,attackDamage,defendStrength,healamount)
        {
            AttackSpell = _attackSpell;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Character type: Mage, Attack spell: {AttackSpell}");
        }

        public override void Attack(Character targetCharacter)
        {
            base.Attack(targetCharacter);
            Console.WriteLine("\n---------------------------------------------------");
            Console.WriteLine($"Warrior {Name} attacks {targetCharacter.Name} with {AttackSpell}");
            Console.WriteLine($"{targetCharacter.Name} is blocking: {targetCharacter.IsBlocking}");
            Console.WriteLine($"{targetCharacter.Name} is health is now: {targetCharacter.Health}");
            Console.WriteLine($"{targetCharacter.Name} current status:");
            targetCharacter.ShowInfo();
            
        }
    }

    public class Program
    {
        static void Main()
        {

            List<Character> teamA = new List<Character>();
            List<Character> teamB = new List<Character>();

            Warrior bob = new Warrior("Bob", 100, 1, 12, 6, 4, "Stapler");
            Mage kristine = new Mage("Kristine", 100, 1, 10, 4, 6, "Devastating Angry Note");
            teamA.Add(bob);
            teamA.Add(kristine);

            Warrior kaci = new Warrior("Kaci", 100, 1, 12, 6, 4, "BrokenBottle");
            Mage gary = new Mage("Gary", 100, 1, 10, 4, 6, "Bad Attitude");
            teamB.Add(kaci);
            teamB.Add(gary);
            
            void KillCharacter(Character doomedCharacter)
            {
                
            }

            void TakeTurn(Character actingCharacter)
            {

                string teamName = "";
                Console.WriteLine($"It is {actingCharacter.Name}'s turn.");
                Console.WriteLine($"Chose an action, {actingCharacter.Name}.");
                Console.WriteLine("1) Attack");
                Console.WriteLine("2) Defend");
                Console.WriteLine("3) Heal");
                Console.Write("--->");
                int playerChoice = -1;
                while (playerChoice < 0 || playerChoice > 3)
                {
                    playerChoice = Convert.ToInt32(Console.ReadLine());
                }

                switch (playerChoice)
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
    }
}