using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ContentOfForm : MonoBehaviour
{
    public string folderName;
    public GameObject itemPrefab;
    public bool isContentButtons;
    public GameObject from, to;

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
        var files = directory.GetFiles();

        for(int i=0; i < files.Length; i++)
        {
            GameObject item = Instantiate(itemPrefab, this.transform);

            item.GetComponent<RectTransform>().anchoredPosition = Vector2.down * i * itemPrefab.GetComponent<RectTransform>().rect.height;

            string processedText = files.GetValue(i).ToString().Substring(path.Length);
            item.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = processedText;

            if (isContentButtons)
            {
                item.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(delegate { MapImageLoader(processedText); });
            }
        }

    }

    public void MapImageLoader(string mapName)
    {
        to.GetComponent<UnityEngine.UI.Image>().sprite = SaveSystem.LoadMapImage(mapName);
    }
}
