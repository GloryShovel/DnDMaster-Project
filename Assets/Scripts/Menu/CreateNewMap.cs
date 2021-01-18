using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewMap : MonoBehaviour
{
    /*
     * This class is just for saving maps from menu form
     */
    public GameObject mapName, mapImage, spawn;

    public void SaveIt()
    {
        SaveSystem.SaveMap(GatherData());
    }

    Map GatherData()
    {
        string mapName = this.mapName.gameObject.GetComponent<UnityEngine.UI.Text>().text;
        string mapImage = this.mapImage.gameObject.GetComponent<ContentOfForm>().activeMapImageName;
        Vector2 xPosition = this.spawn.gameObject.GetComponent<RectTransform>().anchoredPosition;
        Vector2 spawnPointNormalized = Vector2.zero;
        spawnPointNormalized.x = xPosition.x / spawn.transform.parent.GetComponent<RectTransform>().sizeDelta.x;
        spawnPointNormalized.y = xPosition.y / spawn.transform.parent.GetComponent<RectTransform>().sizeDelta.y;

        Map map = new Map(mapName, mapImage, spawnPointNormalized);
        return map;
    }
}
