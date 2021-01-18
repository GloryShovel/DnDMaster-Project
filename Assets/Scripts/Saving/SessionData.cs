using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SessionData
{
    public string sessionName;
    public List<string> mapsNames;

    public SessionData(Session session)
    {
        sessionName = session.sessionName;

        foreach(Map map in session.maps)
        {
            mapsNames.Add(map.mapName);
        }
    }
}
