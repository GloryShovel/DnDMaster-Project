using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string characterName;
    public int strengh, dextirity, constitution, inteligence, wisdom, charisma;
    //TODO: add Race and Class (might be different class)

    public Character(){}

    public Character(string characterName, int strengh, int dextirity, int constitution, int inteligence, int wisdom, int charisma)
    {
        this.characterName = characterName;
        this.strengh = strengh;
        this.dextirity = dextirity;
        this.constitution = constitution;
        this.inteligence = inteligence;
        this.wisdom = wisdom;
        this.charisma = charisma;
    }

    public void Save()
    {
        SaveSystem.SaveCharcter(this);
    }

    public void Load(string charName)
    {
        CharacterData data = SaveSystem.LoadCharacter(charName);

        this.characterName = data.characterName;
        this.strengh = data.strengh;
        this.dextirity = data.dextirity;
        this.constitution = data.constitution;
        this.inteligence = data.inteligence;
        this.wisdom = data.wisdom;
        this.charisma = data.charisma;
    }
}
