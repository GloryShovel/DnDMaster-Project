using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session
{
    public string sessionName;
    public List<Map> maps;

    public Session()
    {

    }

    public Session(string sessionName, List<Map> maps)
    {
        this.sessionName = sessionName;
        this.maps = maps;
    }

    public void Save()
    {
        SaveSystem.SaveSession(this);
    }

    public void Load(string sessionName)
    {
        SessionData data = SaveSystem.LoadSession(sessionName);

        this.sessionName = data.sessionName;

        List<Map> maps = new List<Map>();
        foreach(string mapName in data.mapsNames)
        {
            Map map = new Map();
            map.Load(mapName);
            maps.Add(map);
        }
        this.maps = maps;
    }
}
