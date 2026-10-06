namespace Project_1
{
    class townFunc
    {
        public static void town()
        {
            Console.WriteLine("You are in the woods. You see a path that leads to a town. You have been in the woods for days. Do you want to go to the town?\nType yes or no");
            string answer = Console.ReadLine() ?? "";
            if (answer == "yes")
            {
                Console.WriteLine("You are in the town! You see a shop and a motel. Where do you want to go?\nType a for the shop or b for the motel");
                string option = Console.ReadLine() ?? "";

                if (option == "a")
                {
                    shopFunc.shop();
                }
                else if (option == "b")
                {
                    motelFunc.motel();
                }
                else
                {
                    Console.WriteLine("That is not a valid choice.");
                }
            }
            else
            {
                Console.WriteLine("You stay in the woods.");
            }
        }
    }

    class motelFunc
    {
        public static void motel()
        {
            Console.WriteLine("Welcome to the motel! You can rest here and recover your health. It costs 20 gold to stay the night. Do you want to stay?\nType yes or no");
            string stayOption = Console.ReadLine() ?? "";

            if (stayOption == "yes")
            {
                if (GameState.gold >= 20)
                {
                    GameState.gold -= 20;
                    GameState.health += 10;
                    Console.WriteLine($"You stayed the night and recovered your health! Your health is now {GameState.health} and your gold is {GameState.gold}. Do you want to go back to the town?\nType yes or no");
                    string townOption = Console.ReadLine() ?? "";
                    if (townOption == "yes")
                    {
                        townFunc.town();
                    }
                    else
                    {
                        Console.WriteLine("You decide to stay at the motel.");
                    }
                }
                else
                {
                    Console.WriteLine("You don't have enough gold to stay the night. Maybe next time!");
                    townFunc.town();
                }
            }
            else if (stayOption == "no")
            {
                Console.WriteLine("You decide not to stay.");
                townFunc.town();
            }
            else
            {
                Console.WriteLine("Maybe next time!");
                townFunc.town();
            }
        }
    }

    class shopFunc
    {
        public static void shop()
        {
            Console.WriteLine($"Player Health: {GameState.health}");
            Console.WriteLine($"Player Gold: {GameState.gold}");
            Console.WriteLine($"Player Experience: {GameState.exp}");

            if (GameState.foodCount == 0)
            {
                Console.WriteLine("Player's Food: None");
            }
            else
            {
                for (int i = 0; i < GameState.foodCount; i++)
                {
                    Console.WriteLine($"Player food: {GameState.food[i]}");
                }
            }

            if (GameState.weaponCount == 0)
            {
                Console.WriteLine("Player's Weapons: None");
            }
            else
            {
                for (int i = 0; i < GameState.weaponCount; i++)
                {
                    Console.WriteLine($"Player weapon: {GameState.weapons[i]}");
                }
            }

            while (true)
            {
                Console.WriteLine("Hello! Welcome to my shop! Do you need help?\nType yes or no");
                string buy = Console.ReadLine() ?? "";

                if (buy != "yes")
                {
                    Console.WriteLine("Okay, have a good day!");
                    townFunc.town();
                    break;
                }

                Console.WriteLine("What kind of help do you need?\na. I need to get my health up.\nb. I need some more weapons.\nc. I need some food.");
                string answer = Console.ReadLine() ?? "";

                switch (answer)
                {
                    case "a":
                        Console.WriteLine("Okay, I have a health potion and it gives you 10 health! It cost 50 gold. Do you want to buy it?\nType yes or no");
                        string buyHealth = Console.ReadLine() ?? "";
                        if (buyHealth == "yes")
                        {
                            if (GameState.gold >= 50)
                            {
                                GameState.gold -= 50;
                                GameState.health += 10;
                                Console.WriteLine($"You bought a health potion! Your health is now: {GameState.health} and your gold is now: {GameState.gold}!");
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough gold. Maybe next time!");
                            }
                        }
                        break;

                    case "b":
                        Console.WriteLine("Okay, I have a dagger for 100, a sword for 200, and a bow with arrows for 300. Which one do you want?");
                        string weaponOption = Console.ReadLine() ?? "";
                        switch (weaponOption)
                        {
                            case "dagger":
                                if (GameState.gold >= 100)
                                {
                                    if (GameState.weaponCount < GameState.weapons.Length)
                                    {
                                        GameState.gold -= 100;
                                        GameState.weapons[GameState.weaponCount] = "Dagger";
                                        GameState.weaponCount++;
                                        Console.WriteLine($"You just bought a dagger! Your gold is {GameState.gold}.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You can't carry any more weapons!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You don't have enough gold. Maybe next time!");
                                }
                                break;

                            case "sword":
                                if (GameState.gold >= 200)
                                {
                                    if (GameState.weaponCount < GameState.weapons.Length)
                                    {
                                        GameState.gold -= 200;
                                        GameState.weapons[GameState.weaponCount] = "Sword";
                                        GameState.weaponCount++;
                                        Console.WriteLine($"You just bought a sword! Your gold is {GameState.gold}.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You can't carry any more weapons!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You don't have enough gold. Maybe next time!");
                                }
                                break;

                            case "bow with arrows":
                                if (GameState.gold >= 300)
                                {
                                    if (GameState.weaponCount < GameState.weapons.Length)
                                    {
                                        GameState.gold -= 300;
                                        GameState.weapons[GameState.weaponCount] = "Bow with Arrows";
                                        GameState.weaponCount++;
                                        Console.WriteLine($"You just bought a bow with arrows! Your gold is {GameState.gold}.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You can't carry any more weapons!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You don't have enough gold. Maybe next time!");
                                }
                                break;

                            default:
                                Console.WriteLine("I don't have that item.");
                                break;
                        }
                        break;

                    case "c":
                        Console.WriteLine("Okay! I have nuts for 10, bread for 20, and fruit for 30. Which one do you want?");
                        string foodOption = Console.ReadLine() ?? "";

                        switch (foodOption)
                        {
                            case "nuts":
                                if (GameState.gold >= 10)
                                {
                                    if (GameState.foodCount < GameState.food.Length)
                                    {
                                        GameState.gold -= 10;
                                        GameState.food[GameState.foodCount] = "Nuts";
                                        GameState.foodCount++;
                                        Console.WriteLine($"You bought nuts! Your gold is {GameState.gold}.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You can't carry any more food!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You don't have enough gold. Maybe next time!");
                                }
                                break;

                            case "bread":
                                if (GameState.gold >= 20)
                                {
                                    if (GameState.foodCount < GameState.food.Length)
                                    {
                                        GameState.gold -= 20;
                                        GameState.food[GameState.foodCount] = "Bread";
                                        GameState.foodCount++;
                                        Console.WriteLine($"You bought bread! Your gold is {GameState.gold}.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You can't carry any more food!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You don't have enough gold. Maybe next time!");
                                }
                                break;

                            case "fruit":
                                if (GameState.gold >= 30)
                                {
                                    if (GameState.foodCount < GameState.food.Length)
                                    {
                                        GameState.gold -= 30;
                                        GameState.food[GameState.foodCount] = "Fruit";
                                        GameState.foodCount++;
                                        Console.WriteLine($"You bought fruit! Your gold is {GameState.gold}.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You can't carry any more food!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You don't have enough gold. Maybe next time!");
                                }
                                break;

                            default:
                                Console.WriteLine("I don't have that item.");
                                break;
                        }
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Do you want to keep shopping? Type yes or no");
                string continueShopping = Console.ReadLine() ?? "";

                if (continueShopping != "yes")
                {
                    Console.WriteLine("Thanks for shopping! See you next time!");
                    townFunc.town();
                    break;

                }
            }
        }
    }
}
