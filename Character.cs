using System;

namespace RPG_C_
{
internal class Character : Player
{
    private string charName;

    private CharacterClass @class;


    public Character(string charName, CharacterClass @class, int healthPoint, int attackPoint, int defensePoint, int level, int expPoint,int manaPoint)
        : base(healthPoint, attackPoint, defensePoint, level, expPoint, manaPoint)
    {
        this.charName = charName;
        this.@class = @class;

    }

    public string HeroName
    {
        get
        {
            return this.charName;
        }
    }

    public CharacterClass CharacterClass
    {
        get
        {
            return this.@class;
        }}

    
    public static Character ClassSelect(string charName, CharacterClass @class)
    {
        var healthPoint = 100;
        var attackPoint = 10;
        var defensePoint = 5;
        var level = 1;
        var expPoint= 0;
        var manaPoint=30;

        switch (@class)
        {
            case CharacterClass.Paladin:
                healthPoint = healthPoint + 20;
                attackPoint=attackPoint + 10;
                defensePoint=defensePoint + 5;
                break;
            case CharacterClass.Warrior:
                healthPoint = healthPoint + 20;
                attackPoint=attackPoint +15;
                break;
            case CharacterClass.Mage:
                  manaPoint = manaPoint + 20;
                break;
        }

        return new Character(charName, @class, healthPoint, attackPoint, defensePoint, level, expPoint, manaPoint);
    }
}}