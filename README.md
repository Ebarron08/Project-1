int playerHealth = 10;
int gold = 564;
string weapon = "None";
string food = "None";
int exp = 4;

Console.WriteLine("Player Health: " + playerHealth);
Console.WriteLine("Player Gold: " + gold);
Console.WriteLine("Player Food" + food);
Console.WriteLine("Player Weapons: " + weapon);

Console.WriteLine("Player Experience: " + exp);

while (true)
{
    Console.WriteLine("Hello! Welcome to my shop! Do you need help?\nType yes or no");
    string response = Console.ReadLine() ?? "";

    if (response != "yes")
    {
        Console.WriteLine("Okay, have a good day!");
        break;
    }

    Console.WriteLine("What kind of help do you need?\na. I need to get my health up.\nb. I need some more weapons.\nc. I need some food.");
    string answer = Console.ReadLine() ?? "";

    if (answer == "a")
    {
        Console.WriteLine("Okay, I have a health potion! It cost 50 gold. Do you want to buy it?\nType yes or no");
        if (response == "yes")
        {
            if (gold >= 50)
            {
                gold -= 50;
                playerHealth += 10;
                Console.WriteLine("You bought a health potion! Your health is now: " + playerHealth + " and your gold is now: " + gold + "!" + " Goodbye!");
            }
            else
            {
                Console.WriteLine("You don't have enough gold. Maybe next time!");
            }
        }
    }
    // If Player picks weapons
    string option = Console.ReadLine() ?? "";
    if (answer == "b")
        {
            Console.WriteLine("Okay, I have a dagger for 100, a sword for 200, and a bow with arrows for 300. Which one do you want?");
            option = Console.ReadLine() ?? "";
            if (option == "dagger")
            {
                if (gold >= 100)
                {
                    gold -= 100;
                    weapon = "Dagger";
                    Console.WriteLine("You just bought a dagger! You have " + weapon + " and your gold is " + gold + "." + " Goodbye!");
                }
                else
                {
                    Console.WriteLine("You don't have enough gold. Maybe next time!");
                }
            }
            else if (option == "sword")
            {
                if (gold >= 200)
                {
                    gold -= 200;
                    weapon = "Sword";
                    Console.WriteLine("You just bought a sword! You have " + weapon + " and your gold is " + gold + "." + " Goodbye!");
                }
                else
                {
                    Console.WriteLine("You don't have enough gold. Maybe next time!");
                }
            }
            else if (option == "bow with arrows")
            {
                if (gold >= 300)
                {
                    gold -= 300;
                    weapon = "Bow with Arrows";
                    Console.WriteLine("You just bought a bow with arrows! You have " + weapon + "and your gold is " + gold + "." + " Goodbye!");
                }
                else
                {
                    Console.WriteLine("You dont have enough gold. Maybe next time!");
                }
            }
        }
    
        if (answer == "c")
            {
                Console.WriteLine("Okay! I have nuts for 10, bread for 20, and  fruit for 30. Which one do you want?");
                string foodOption = Console.ReadLine() ?? "";

                if (foodOption == "nuts")
                {
                    if (gold >= 10)
                    {
                        gold -= 10;
                        food = "Nuts";
                        Console.WriteLine("You bought nuts! You have " + food + " and your gold is " + gold + ".");
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough gold. Maybe next time!");
                    }
                }
                else if (foodOption == "bread")
                {
                    if (gold >= 20)
                    {
                        gold -= 20;
                        food = "Bread";
                        Console.WriteLine("You bought bread! You have " + food + " and your gold is " + gold + ".");

                    }
                    else
                    {
                        Console.WriteLine("You don't have enough gold. Maybe next time!");
                    }
                }
                else if (foodOption == "fruit")
                {
                    if (gold >= 30)
                    {
                        gold -= 30;
                        food = "Fruit";
                        Console.WriteLine("You bought fruit! You have " + food + " and your gold is " + gold + ".");
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough gold. Maybe next time!");
                    }
                }
            }

    Console.WriteLine();
    Console.WriteLine("Do you want to keep shopping? Type yes or no");
    string continueShopping = Console.ReadLine() ?? "";

    if (continueShopping != "yes")
    {
        Console.WriteLine("Thanks for shopping! See you next time!");
        break;
    }
}