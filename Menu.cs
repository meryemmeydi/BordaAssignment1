using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace RPG_C_
{
public partial class Menu
{
    public static void Options()
    {
        Console.WriteLine("1. New Game\n" +
                          "2. Load Game\n" +
                          "3. Exit Game\n");
        var choice = Console.ReadLine();
        var correctChoice = false;
        Player newPlayer = null;
        while (!correctChoice)
        {
            switch (choice)
            {
                case "1":
                    newPlayer = CharacterCreation.CreateCharacter();
                    correctChoice = true;
                    break;
                case "2":
                    Console.WriteLine("This feature is not yet implemented.");
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Please enter a correct value.");
                    break;
            }

            if (!correctChoice)
            {
                choice = Console.ReadLine();
            }
        }


        Console.ReadLine();

}

}

}