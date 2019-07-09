using System;

namespace RPG_C_
{
internal class CharacterCreation
{
    public static Character CreateCharacter()
    {
        Console.WriteLine("\nWe will proceed in character creation.");
        Console.WriteLine("Please enter your character name:");

        var charName = Console.ReadLine();

        Console.WriteLine("\nNow choose your character: \n" +
                          "1-->Paladin\n" +
                          "2-->Mage\n" +
                          "3-->Warrior");
                          

        var classChoice = Console.ReadLine();
        var correctChoice = false;
        var charClass = CharacterClass.Unknown;

        while (!correctChoice)
        {
            switch (classChoice)
            {
                case "1":
                    charClass = CharacterClass.Paladin;
                    correctChoice = true;
                    break;
                case "2":
                    charClass = CharacterClass.Mage;
                    correctChoice = true;
                    break;
                case "3":
                    charClass = CharacterClass.Warrior;
                    correctChoice = true;
                    break;
                default:
                    Console.WriteLine("Please enter a correct value.");
                    break;
            }

            if (!correctChoice)
            {
                classChoice = Console.ReadLine();
            }
        }

        return Character.ClassSelect(charName, charClass);
    }
}}