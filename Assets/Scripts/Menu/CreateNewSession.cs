using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewSession : MonoBehaviour
{
    /*
     * This class is just for saving maps from menu form
     */

    public GameObject sessionName, mapList;

    public void SaveIt()
    {
        Session ses = GatherData();
        Debug.Log(ses.sessionName);
        foreach(Map map in ses.maps)
        {
            Debug.Log(map.mapName);
        }
        //SaveSystem.SaveSession(GatherData());
    }

    Session GatherData()
    {
        string name = this.sessionName.gameObject.GetComponent<UnityEngine.UI.Text>().text;

        List<Map> maps = new List<Map>();
        for(int i=0; i < mapList.transform.childCount; i++){
            Map temp = new Map();
            string tempName = mapList.transform.GetChild(i).GetChild(0).GetComponent<UnityEngine.UI.Text>().text;
            temp.Load(tempName.Substring(0, tempName.Length - 5));
            maps.Add(temp);
        }

        Session session = new Session(name, maps);
        return session;
    }
}
