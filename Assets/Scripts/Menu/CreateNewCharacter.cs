using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewCharacter : MonoBehaviour
{
    /*
     * This class is just for saving character from menu form
     */

    public GameObject charName, strengh, dextirity, constitution, inteligence, wisdom, charisma;

    public void SaveIt()
    {
        SaveSystem.SaveCharcter(GatherData());
    }

    Character GatherData()
    {
        /*
         * Gathers data from form and creates character to be saved
         */

        //TODO: check does input contain value
        string charN = charName.gameObject.GetComponent<UnityEngine.UI.Text>().text;
        int s = int.Parse(strengh.gameObject.GetComponent<UnityEngine.UI.Text>().text);
        int d = int.Parse(dextirity.gameObject.GetComponent<UnityEngine.UI.Text>().text);
        int con = int.Parse(constitution.gameObject.GetComponent<UnityEngine.UI.Text>().text);
        int i = int.Parse(inteligence.gameObject.GetComponent<UnityEngine.UI.Text>().text);
        int w = int.Parse(wisdom.gameObject.GetComponent<UnityEngine.UI.Text>().text);
        int cha = int.Parse(charisma.gameObject.GetComponent<UnityEngine.UI.Text>().text);

        Character character = new Character(charN, s,d, con,i, w, cha);

        return character;
    }


}
