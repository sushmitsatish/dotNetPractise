namespace pokemon.legionOfLegends
{
    //CREATED BY SUSHMIT "5ykik" SATISH

    public class Battle
    {
        public string name;
        //The variable choice helps decide the attack which is used during the battle.
        public int choice;
        public int damage;

        //Declaring objects for the Player and Opponent class to access their data members.
        Player p1 = new Player();
        Opponent o1 = new Opponent();

        //USING RANDOM CLASS TO GENERATE RANDOMISED HIT POINTS
        Random rand = new Random();

        //Returns 1 if player has won, 2 if player has lost, 3 if match is still ongoing
        public int checkBattle()
        {
            if (p1.pHealth > 0 && o1.oHealth > 0)
            {
                return 3;
            }
            else if (p1.pHealth <= 0)
                return 2;
            else if (o1.oHealth <= 0)
                return 1;
            return 3;
        }
        //Function to set the player name.
        public void setName()
        {
            Console.WriteLine("Hey there!! I'm Professor Oak!! What did you say your name was again?");
            name = Console.ReadLine();
            Console.WriteLine("Ah yes!! I see you're ready for your first fight, " + name + "!!!");
        }

        //Function for player's turn to attack.
        public void playerAttack()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n" + name + "'s turn!!!");
            Console.WriteLine("Press, 1: Ember (AP Cost: 1), 2: Fire Spin(AP Cost: 2),\n3: FlameThrower(AP Cost: 3), 4: Seismic Toss(AP Cost: 5)");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    if (p1.pAttackPoints < 1)
                    {
                        goto DEFAULT;
                    }

                    Console.WriteLine("\nCharizard used Ember.");
                    damage = rand.Next(1, 10);
                    o1.oHealth -= damage;
                    p1.pAttackPoints -= 1;
                    Console.WriteLine("Charizard dealt " + damage + " damage.");
                    break;
                case 2:
                    if (p1.pAttackPoints < 2)
                    {
                        goto DEFAULT;
                    }

                    Console.WriteLine("\nCharizard used Fire Spin.");
                    damage = rand.Next(5, 15);
                    o1.oHealth -= damage;
                    p1.pAttackPoints -= 2;
                    Console.WriteLine("Charizard dealt " + damage + " damage.");
                    break;
                case 3:
                    if (p1.pAttackPoints < 3)
                    {
                        goto DEFAULT;
                    }

                    Console.WriteLine("\nCharizard used FlameThrower.");
                    damage = rand.Next(15, 25);
                    o1.oHealth -= damage;
                    p1.pAttackPoints -= 3;
                    Console.WriteLine("Charizard dealt " + damage + " damage.");
                    break;
                case 4:
                    if (p1.pAttackPoints < 5)
                    {
                        goto DEFAULT;
                    }

                    Console.WriteLine("\nCharizard used Seismic Toss.");
                    damage = rand.Next(5, 45);
                    o1.oHealth -= damage;
                    p1.pAttackPoints -= 5;
                    Console.WriteLine("Charizard dealt " + damage + " damage.");
                    break;
                default:
                DEFAULT:
                    Console.WriteLine("\nCharizard missed his shot.");
                    break;
            }
            Console.WriteLine("\nCharizard's HP: " + p1.pHealth + ", Attack points (AP) remaining: " + p1.pAttackPoints);
            Console.WriteLine("Magmar's HP: " + o1.oHealth);
        }

        //Function for opponent's turn to attack.
        public void opponentAttack()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            choice = rand.Next(1, 4);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nMagmar used Ember.");
                    damage = rand.Next(5, 10);
                    p1.pHealth -= damage;
                    Console.WriteLine("Magmamr dealt " + damage + " damage.");
                    break;
                case 2:
                    Console.WriteLine("\nMagmar used Flame Tower.");
                    damage = rand.Next(8, 15);
                    p1.pHealth -= damage;
                    Console.WriteLine("Magmamr dealt " + damage + " damage.");
                    break;
                case 3:
                    Console.WriteLine("\nMagmar used Magma Gun.");
                    damage = rand.Next(15, 20);
                    p1.pHealth -= damage;
                    Console.WriteLine("Magmamr dealt " + damage + " damage.");
                    break;
                case 4:
                    Console.WriteLine("\nMagmar used Purgatory.");
                    damage = rand.Next(15, 50);
                    p1.pHealth -= damage;
                    Console.WriteLine("Magmamr dealt " + damage + " damage.");
                    break;
            }
            Console.WriteLine("\nCharizard's HP: " + p1.pHealth + ", Attack points (AP) remaining: " + p1.pAttackPoints);
            Console.WriteLine("Magmar's HP: " + o1.oHealth);

        }

        //Function to display stats.
        public void displayStats()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCharizard's HP: " + p1.pHealth + ", Attack points (AP) remaining: " + p1.pAttackPoints);
            Console.WriteLine("Magmar's HP: " + o1.oHealth);
        }
    }

    //Player class to hold player's information.
    public class Player
    {
        public int pHealth = 100;

        //Attack points basically defines how many AP the player has left, using which he/she can 
        //use various attack types.
        public int pAttackPoints = 20;

    }

    //Opponent class to hold opponent's information.
    public class Opponent
    {
        public int oHealth = 100;
    }
    public class mainClass
    {
        public static void Main(string[] args)
        {
            //INTRO SCREEN
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\tWelcome to");
            Console.WriteLine("  POKEMON: LEGION OF LEGENDS");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Press any key to Begin your POKEMON adventure!!!");
            Console.ReadKey();
            Console.Clear();

            //Creating the object for Battle class, through which we run the entire game.
            Battle driverObj = new Battle();
            driverObj.setName();

            //INSTRUCTIONS SCREEN
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Welcome to the world of Pokemon!! Today, you will be fighting with an opponent, one on one.");
            Console.WriteLine("\nThe rules are simple. Both you and your opponent take turns to attack one another. ");
            Console.WriteLine("The first one who's Pokemon faints loses the match!! Your pokemon is \"CHARIZARD\".");
            Console.WriteLine("Your opponent's Pokemon is \"Magmar\".");
            Console.WriteLine("\nEach attack consumes some attack points. If you run out of attack points, you'll miss your");
            Console.WriteLine("shot. Trying to do a attack without sufficient attack points will also result in a miss.");
            Console.WriteLine("Let the battle begin!!");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            Console.Clear();
            for (int i = 0; i < 100; ++i)
            {
                if (driverObj.checkBattle() == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nMagmar Fainted!!! " + driverObj.name + " is the winner!!!");
                    break;
                }
                else if (driverObj.checkBattle() == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nCharizard Fainted!!! " + driverObj.name + " loses the battle!!!");
                    break;
                }
                else if (driverObj.checkBattle() == 3)
                {
                    driverObj.displayStats();
                    driverObj.playerAttack();
                    driverObj.opponentAttack();

                    Console.WriteLine("\nPress any key for next turn.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}