using System;

namespace RPG_C_
{
internal class CpuPlayer : Player {

        private String name= "Monster";
      public CpuPlayer(string name,int healthPoint, int attackPoint, int defensePoint, int level, int expPoint,int manaPoint)
        : base(healthPoint, attackPoint, defensePoint, level, expPoint, manaPoint)
    {
        this.name = name;
        this.healthPoint=100;
        this.attackPoint=15;
        this.defensePoint=10;

    }









}

}