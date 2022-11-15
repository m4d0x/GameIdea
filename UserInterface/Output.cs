﻿using GameLogic;

namespace UserInterface;

public class Output
{
    public static void MainMenu()
    {
        Console.WriteLine("Welcome to World of Heretics!");
        WriteLineColored((ConsoleColor.White, "Press "), (ConsoleColor.Red, "[P]"), (ConsoleColor.White, " to play.."));
        WriteLineColored((ConsoleColor.White, "..or "), (ConsoleColor.Red, "[Q]"), (ConsoleColor.White, " to quit game..")); 
        //Console.WriteLine("Press [P] to play..\n..or press [Q] to quit game!");
    }

    public static void CharacterHandlerOutPut()
    {
        Console.WriteLine("Character menu:");
        WriteLineColored((ConsoleColor.Red, "[C]reate "), (ConsoleColor.White, "character"), (ConsoleColor.White, "."));
        WriteLineColored((ConsoleColor.Red, "[L]oad "), (ConsoleColor.White, "character"), (ConsoleColor.White, "."));
        WriteLineColored((ConsoleColor.Red, "[R]eturn "), (ConsoleColor.White, "to main menu"), (ConsoleColor.White, "."));
        //Console.WriteLine("[C]reate character");
        //Console.WriteLine("[L]oad character"); // not possible yet without db
        //Console.WriteLine("[R]eturn to main menu");
    }

    public static void ChooseCharacterVocation()
    {
        Console.WriteLine("Choose a class by pressing the corresponding alphabetical character:");
        WriteLineColored((ConsoleColor.Red, "[A]rcher "), (ConsoleColor.White, "- An expert in distance fighting"), (ConsoleColor.White, "."));
        WriteLineColored((ConsoleColor.Red, "[M]age "), (ConsoleColor.White, "- Wielder of magic and spells"), (ConsoleColor.White, "."));
        WriteLineColored((ConsoleColor.Red, "[W]arrior "), (ConsoleColor.White, "- User of handheld weaponry"), (ConsoleColor.White, "."));
        //Console.WriteLine("[A]rcher - An expert in distance fighting.");
        //Console.WriteLine("[M]age - Wielder of magic and spells.");
        //Console.WriteLine("[W]arrior - User of handheld weaponry.");
    }

    public static void CharacterName()
    {
        Console.Write("Pick a name for your character: ");
    }

    public static void ShopMenu()
    {
        Console.WriteLine("Welcome to the WoH shop!");
        WriteLineColored((ConsoleColor.Red, "[B] "), (ConsoleColor.White, " - Buy "), (ConsoleColor.White, "items."));
        WriteLineColored((ConsoleColor.Red, "[S] "), (ConsoleColor.White, " - Sell "), (ConsoleColor.White, "items."));
        WriteLineColored((ConsoleColor.Red, "[L] "), (ConsoleColor.White, "Leave "), (ConsoleColor.White, "shop."));
        //Console.WriteLine("[B]uy\n[S]ell\n[L]eave");
    }

    public static void BuyFromShop(List<Item> shopItems)
    {
        Console.WriteLine("--------BUYING---------");
        foreach (var item in shopItems)
        {
            Console.WriteLine($"{item.Name} - {item.Currency} ");
        }

        Console.WriteLine($"Example: You've bought \"item.Name\" from Shop");
        Console.WriteLine("[R]eturn");
    }

    public static void SellToShop(Character activePlayer)
    {
        foreach (var item in activePlayer.InventoryItems)
        {
            //bör listas med siffra för att avgöra vilket item som ska säljas i genom output/input
            Console.WriteLine($"{item.Name} - Sell for: {item.Currency} ");
        }

        Console.WriteLine("---------SELLING---------");
        Console.WriteLine($"Example: Your item {activePlayer.InventoryItems[1]}");
        Console.WriteLine("[R]eturn");
    }

    public static void TutorialMenu(Character player)
    {
        Console.WriteLine($"Hi! {player.Name}, press any of the below characters to go forward:");
        WriteLineColored((ConsoleColor.Red, "[T] "), (ConsoleColor.White, "Start "), (ConsoleColor.White, "tutorial."));
        WriteLineColored((ConsoleColor.Red, "[R] "), (ConsoleColor.White, "Return "), (ConsoleColor.White, "to map."));
        
        //Console.WriteLine($"[T] Start tutorial.");
        //Console.WriteLine("[R] Return to map");
        //Console.WriteLine("You are done with your practice young padawan! GOOD JOB!!");
    }

    public static void TutorialOutput()
    {
        WriteLineColored((ConsoleColor.White, "Welcome to the "), (ConsoleColor.Red, "World of Heretics "), (ConsoleColor.White, "young adventurer!"));
        Console.WriteLine($"Outside the House of Tutorial you just witnessed the map of WoH.");
        WriteLineColored((ConsoleColor.White, "In this map there´s"), (ConsoleColor.Red, " 4 structures "), (ConsoleColor.White, ", giving 4 different options;\n"));
        WriteLineColored((ConsoleColor.Red, " - North West - "), (ConsoleColor.White, "Our in game Shop where you can buy "), (ConsoleColor.White, "and sell your looted items."));
        WriteLineColored((ConsoleColor.Red, " - North East - "), (ConsoleColor.White, "The Mountain of adventures "), (ConsoleColor.White, "(to be released shortly)."));
        WriteLineColored((ConsoleColor.Red, " - South West - "), (ConsoleColor.White, "Tutorial "), (ConsoleColor.White, "(Which house you just entered and found yourself in this text)"));
        WriteLineColored((ConsoleColor.Red, " - South East - "), (ConsoleColor.White, "Fighting is where you´re able to encounter monsters, "), (ConsoleColor.White, "level up and loot items."));
        
        
        
        //Console.WriteLine($"Welcome to the World of Heretics young adventurer!");
        //Console.WriteLine($"In this map there´s 4 areas with 4 different options;");
        //Console.WriteLine($" - North West - Our in game Shop where you can buy and sell your looted items.");
        //Console.WriteLine($" - North East - The Mountain of adventures (to be released shortly).");
        //Console.WriteLine($" - South West - Tutorial (Which house you just entered and found yourself in this text)");
        //Console.WriteLine($" - South East - Fighting is where you´re able to encounter monsters, level up and loot items.");
    }

    public static void FightStartMenu(Character player)
    {
        Console.WriteLine($"{player.Name}, you´re fighting our enemies, SEND THEM TO HELL!");
        WriteLineColored((ConsoleColor.Red, "[F]"), (ConsoleColor.White, "ight"), (ConsoleColor.White, "!"));
        WriteLineColored((ConsoleColor.Red, "[R]"), (ConsoleColor.White, "un away and live to fight another day"), (ConsoleColor.White, "!"));
        //Console.WriteLine("[F]ight!");
        //Console.WriteLine("[R]un away and live to fight another day!");
    }

    public static void FightingMenu(Game game)
    {
        //Console.WriteLine(game.HandleFighting(Enemy.TestEnemy())); // ska ändras sen
        Console.WriteLine("------------");
    }

    public static void WonMenu()
    {
        Console.WriteLine("You´ve defeated your enemy and won the battle!");
    }

    public static void LoseMenu(Character player)
    {
        Console.WriteLine($"RIP {player.Name}, you´ve died and will have to restart your journey!");
    }

    public static void Quit()
    {
        Console.WriteLine("Farewell young adventurer, your game is saved and we hope to see you soon!");
    }

    public static void TestRoamingMenu() //temporary fix for roaming map interactions
    {
        Console.WriteLine("---------ROAMING---------");
        WriteLineColored((ConsoleColor.Red, "[1.] "), (ConsoleColor.White, "Fight Club"), (ConsoleColor.White, "!"));
        WriteLineColored((ConsoleColor.Red, "[2.] "), (ConsoleColor.White, "Shop"), (ConsoleColor.White, "!"));
        WriteLineColored((ConsoleColor.Red, "[3.] "), (ConsoleColor.White, "Tutorial"), (ConsoleColor.White, "!"));
        WriteLineColored((ConsoleColor.Red, "[4.] "), (ConsoleColor.White, "Leave"), (ConsoleColor.White, "!"));
        //Console.WriteLine("[1.] Fight Club");
        //Console.WriteLine("[2.] Shop");
        //Console.WriteLine("[3.] tutorial");
        //Console.WriteLine("[4.] Leave");
    }

    public static void WriteLineColored(params (ConsoleColor color, string value)[] values)
    {
        Console.Write("\r");
        foreach (var value in values)
        {
            Console.ForegroundColor = value.color;
            Console.Write(value.value);
        }

        Console.Write("\r\n");
        Console.ResetColor();
    }
}