using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map
{
    /* TODO:
     * - Store items on ground
     * - Implement shadowOfWar feature
     */

    public string mapName;
    public string mapImage;
    public List<Character> players, npc, enemies;
    public List<Vector2> playersPosition, npcPosition, enemiesPosition;
    public Vector2 spawnPointNormalized;

    public Map(){}

    public Map(string mapName, string mapImage, Vector2 spawnPointNormalized)
    {
        this.mapName = mapName;
        this.mapImage = mapImage;
        players = new List<Character>();
        npc = new List<Character>();
        enemies = new List<Character>();
        playersPosition = new List<Vector2>();
        npcPosition = new List<Vector2>();
        enemiesPosition = new List<Vector2>();
        this.spawnPointNormalized = spawnPointNormalized;
    }

    public void Save()
    {
        SaveSystem.SaveMap(this);
    }

    public void Load(string mapName)
    {
        MapData data = SaveSystem.LoadMap(mapName);
        Debug.Log(data.mapName);

        this.mapName = data.mapName;
        this.mapImage = data.mapImage;

        //Players
        List<Character> players = new List<Character>();
        foreach(string characterName in data.playersName)
        {
            Character temp = new Character();
            temp.Load(characterName);
            players.Add(temp);
        }
        this.players = players;

        List<Vector2> playersPositions = new List<Vector2>();
        for (int i = 0; i < data.playersPositionX.Count; i++)
        {
            Vector2 pos = Vector2.zero;
            pos.x = data.playersPositionX[i];
            pos.y = data.playersPositionY[i];
            playersPositions.Add(pos);
        }
        this.playersPosition = playersPositions;

        //NPCs
        List<Character> npc = new List<Character>();
        foreach (string npcName in data.npcName)
        {
            Character temp = new Character();
            temp.Load(npcName);
            npc.Add(temp);
        }
        this.npc = npc;

        List<Vector2> npcPositions = new List<Vector2>();
        for (int i = 0; i < data.npcPositionX.Count; i++)
        {
            Vector2 pos = Vector2.zero;
            pos.x = data.npcPositionX[i];
            pos.y = data.npcPositionY[i];
            npcPositions.Add(pos);
        }
        this.npcPosition = npcPositions;

        //Enemies
        List<Character> enemies = new List<Character>();
        foreach (string enemiesName in data.enemiesName)
        {
            Character temp = new Character();
            temp.Load(enemiesName);
            npc.Add(temp);
        }
        this.enemies = enemies;

        List<Vector2> enenmiesPositions = new List<Vector2>();
        for (int i = 0; i < data.enemiesPositionX.Count; i++)
        {
            Vector2 pos = Vector2.zero;
            pos.x = data.enemiesPositionX[i];
            pos.y = data.enemiesPositionY[i];
            enenmiesPositions.Add(pos);
        }
        this.enemiesPosition = enenmiesPositions;

        playersPosition = new List<Vector2>();
        npcPosition = new List<Vector2>();
        enemiesPosition = new List<Vector2>();

        Vector2 spawn = Vector2.zero;
        spawn.x = data.spawnPointNormalizedX;
        spawn.y = data.spawnPointNormalizedY;
        this.spawnPointNormalized = spawn;
    }
}
