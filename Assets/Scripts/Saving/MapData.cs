using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MapData
{
    public string mapName;
    public string mapImage;
    public List<string> playersName, npcName, enemiesName;
    public List<float> playersPositionX, npcPositionX, enemiesPositionX;
    public List<float> playersPositionY, npcPositionY, enemiesPositionY;
    public float spawnPointNormalizedX, spawnPointNormalizedY;

    public MapData(Map map)
    {
        this.mapName = map.mapName;
        this.mapImage = map.mapImage;

        foreach (Character character in map.players)
        {
            this.playersName.Add(character.characterName);
        }
        foreach(Vector2 vec in map.playersPosition)
        {
            this.playersPositionX.Add(vec.x);
            this.playersPositionY.Add(vec.y);
        }

        foreach (Character character in map.npc)
        {
            this.npcName.Add(character.characterName);
        }
        foreach (Vector2 vec in map.npcPosition)
        {
            this.npcPositionX.Add(vec.x);
            this.npcPositionY.Add(vec.y);
        }

        foreach (Character character in map.enemies)
        {
            this.enemiesName.Add(character.characterName);
        }
        foreach (Vector2 vec in map.enemiesPosition)
        {
            this.enemiesPositionX.Add(vec.x);
            this.enemiesPositionX.Add(vec.y);
        }

        this.spawnPointNormalizedX = map.spawnPointNormalized.x;
        this.spawnPointNormalizedY = map.spawnPointNormalized.y;

    }
}
