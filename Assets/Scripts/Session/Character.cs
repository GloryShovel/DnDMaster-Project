using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    public int strengh, dextirity, constitution, inteligence, wisdom, charisma;

    //TODO: Race and Class

    public Character()
    {

    }

    public Character(string name, int strengh, int dextirity, int constitution, int inteligence, int wisdom, int charisma)
    {
        this.name = name;
        this.strengh = strengh;
        this.dextirity = dextirity;
        this.constitution = constitution;
        this.inteligence = inteligence;
        this.wisdom = wisdom;
        this.charisma = charisma;

    }
}
