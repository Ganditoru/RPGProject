
using UnityEngine;
public class Stats {

    //Defense
    public int health { get; set; }
    public int healtReg { get; set; }
    public int armor { get; set; }
    public int magicRes { get; set; }
    public int movementSP { get; set; }

    //Attack
    public int damage { get; set; }
    public int critRate { get; set; }
    public int attackSpeed { get; set; }
    public int lifeSteal { get; set; }

    //Magic
    public int abilityPower { get; set; }
    public int cooldownRed { get; set; }
    public int mana { get; set; }
    public int manaReg { get; set; }

    public Stats()// initializate all with 0
    {
        //Defence
        health = 0;
        healtReg = 0;
        armor = 0;
        magicRes = 0;
        movementSP = 0;

        //Attack
        damage = 0;
        critRate = 0;
        attackSpeed = 0;
        lifeSteal = 0;

        //Magic
        abilityPower = 0;
        cooldownRed = 0;
        mana = 0;
        manaReg = 0;
    }



}
