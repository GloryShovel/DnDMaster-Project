using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCreator : MonoBehaviour
{
    public GameObject charName, strengh, dextirity, constitution, inteligence, wisdom, charisma;

    public void Save()
    {
        string charN = charName.transform.GetChild(0).GetChild(2).gameObject.GetComponent<UnityEngine.UI.Text>().text;
        int s = int.Parse(strengh.transform.GetChild(0).GetChild(2).gameObject.GetComponent<UnityEngine.UI.Text>().text);
        int d = int.Parse(dextirity.transform.GetChild(0).GetChild(2).gameObject.GetComponent<UnityEngine.UI.Text>().text);
        int con = int.Parse(constitution.transform.GetChild(0).GetChild(2).gameObject.GetComponent<UnityEngine.UI.Text>().text);
        int i = int.Parse(inteligence.transform.GetChild(0).GetChild(2).gameObject.GetComponent<UnityEngine.UI.Text>().text);
        int w = int.Parse(wisdom.transform.GetChild(0).GetChild(2).gameObject.GetComponent<UnityEngine.UI.Text>().text);
        int cha = int.Parse(charisma.transform.GetChild(0).GetChild(2).gameObject.GetComponent<UnityEngine.UI.Text>().text);

        Character character = new Character(charN, s, d, con, i, w, cha);
    }
}
