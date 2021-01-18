using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ContentOfForm : MonoBehaviour
{
    public string folderName;
    public GameObject itemPrefab;
    public bool isMap;
    public GameObject from, to;
    public string activeMapImageName;

    string path;

    void Start()
    {
        if(folderName != null)
        {
            path = Application.persistentDataPath + "/" + folderName + "/";
        }
        else
        {
            path = Application.persistentDataPath;
        }

        DirectoryInfo directory = new DirectoryInfo(path);
        FileInfo[] files;
        if (isMap)
        {
            files = directory.GetFiles("*.jpg");
        }
        else
        {
            files = directory.GetFiles("*.save");
        }

        for(int i=0; i < files.Length; i++)
        {
            GameObject item = Instantiate(itemPrefab, this.transform);

            item.GetComponent<RectTransform>().anchoredPosition = Vector2.down * i * itemPrefab.GetComponent<RectTransform>().rect.height;

            string processedText = files.GetValue(i).ToString().Substring(path.Length);
            item.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = processedText;

            if (isMap)
            {
                item.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(delegate { MapImageLoader(processedText); activeMapImageName = processedText; });
            }
            else
            {
                item.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(delegate { AddMapToSession(item); });
            }
        }

    }

    public void MapImageLoader(string mapName)
    {
        to.GetComponent<UnityEngine.UI.Image>().sprite = SaveSystem.LoadMapImage(mapName);
    }

    public void AddMapToSession(GameObject thisButton)
    {
        if (thisButton.transform.parent == from.transform)
        {
            thisButton.transform.SetParent(to.transform);
        }
        else
        {
            thisButton.transform.SetParent(from.transform);
        }
        Vector2 position = Vector2.zero;
        position.y = thisButton.GetComponent<RectTransform>().anchoredPosition.y;
        thisButton.GetComponent<RectTransform>().anchoredPosition = position;
    }
}
