using System;


namespace RPG_C_
{
public class Player {
public int healthPoint{get; set;}
public int attackPoint{get; set;}
public int defensePoint{get; set;}

public int level{get; set;}
public int expPoint{get; set;}
public int manaPoint{get; set;}

public Player(int healthPoint,int attackPoint,int defensePoint,int level,int expPoint,int manaPoint){
    this.healthPoint=healthPoint;
    this.attackPoint=attackPoint;
    this.defensePoint=defensePoint;
    this.level=level;
    this.expPoint=expPoint;
    this.manaPoint=manaPoint;

} 

}}