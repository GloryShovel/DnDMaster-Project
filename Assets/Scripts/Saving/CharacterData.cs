using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterData
{
    /*
     * One must update this file when Character Class is edited (if you need to save more data)
     * 
     * TODO:
     * - add Race handler
     * - add Class handler
     */


    public string characterName;
    //Atributes
    public int strengh, dextirity, constitution, inteligence, wisdom, charisma;

    public CharacterData(){}

    public CharacterData(Character character)
    {
        this.characterName = character.characterName;
        this.strengh = character.strengh;
        this.dextirity = character.dextirity;
        this.constitution = character.constitution;
        this.inteligence = character.inteligence;
        this.wisdom = character.wisdom;
        this.charisma = character.charisma;
    }
}
