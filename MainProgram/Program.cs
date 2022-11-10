﻿namespace MainProgram;

using UserInterface;
using GameLogic;
class Program
{
    public static void Main(string[] args)
    {
        GameState gameState = GameState.ShopMenu;
        Game game = new Game("Khaled", "Warrior");

        while (gameState != GameState.QuitGame)
        {
            gameState = GameStateHandler.SwitchMenu(gameState);
        }
    }
}
