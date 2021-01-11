using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
    /* TODO:
     * - Store items on ground
     * - Implement shadowOfWar feature
     */

    public Image mapImage; //<- string?
    public List<Character> npc, enenmies; //<- position, name  
    public Vector2 spawnPoint;


    public Map()
    {

    }

    public Map(Image mapImage, List<Character> npc, List<Character> enenmies, Vector2 spawnPoint)
    {
        this.mapImage = mapImage;
        this.npc = npc;
        this.enenmies = enenmies;
        this.spawnPoint = spawnPoint;
    }

    public void Save()
    {
        SaveSystem.SaveMap(this);
    }

    public void Load(string mapName)
    {
        CharacterData data = SaveSystem.LoadMap(mapName);

        //TODO: make loading
    }
}
