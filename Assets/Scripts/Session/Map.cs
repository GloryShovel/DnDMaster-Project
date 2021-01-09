using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
    public Image mapImage;

    //TODO: fog implementation

    public List<Character> players, npc, enenmies;


    public Map()
    {

    }

    public Map(Image mapImage, List<Character> players, List<Character> npc, List<Character> enenmies)
    {
        this.mapImage = mapImage;
        this.players = players;
        this.npc = npc;
        this.enenmies = enenmies;
    }
}
