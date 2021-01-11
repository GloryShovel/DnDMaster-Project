using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    //NOTE: We might think about making monsters and NPCs as well as characters form program
    //      or just switch this to javascript (becouse dnd allows to make custome made things)

    static string pathToCharacters = Application.persistentDataPath + "/Characters/";
    static string pathToMaps = Application.persistentDataPath + "/Maps/";
    static string pathToMapsImages = Application.persistentDataPath + "/MapsImages/";
    static string pathToSessions = Application.persistentDataPath + "/Sessions/";

    public static void CheckDirectory(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
    }

    /*Index:
     * - Character
     * - Map Images
     * - Map
     * - Session
     */

    //-------------------------------------------------------------------------Character
    public static void SaveCharcter(Character character)
    {
        CheckDirectory(pathToCharacters);

        CharacterData data = new CharacterData(character);

        BinaryFormatter formatter = new BinaryFormatter();
        string path = pathToCharacters + data.characterName + ".save";
        FileStream stream = new FileStream(path, FileMode.Create);

        formatter.Serialize(stream, data);

        stream.Close();
    }

    public static CharacterData LoadCharacter(string characterName)
    {
        string path = pathToCharacters + characterName + ".save";
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Open);

        CharacterData data = formatter.Deserialize(stream) as CharacterData;

        stream.Close();
        return data;
    }


    //-------------------------------------------------------------------------MapImages

    public static Sprite LoadMapImage(string imageName)
    {

        string path = pathToMapsImages + imageName;
        byte[] fileData = File.ReadAllBytes(path);

        Texture2D image = new Texture2D(1,1);
        image.LoadImage(fileData);

        Sprite sprite = Sprite.Create(image, new Rect(0, 0, image.width, image.height), new Vector2(0, 0));

        return sprite;
    } 


    //-------------------------------------------------------------------------Map
    public static void SaveMap(Map map)
    {
        CheckDirectory(pathToMaps);

        MapData data = new MapData(map);

        //Setup formatter
        BinaryFormatter formatter = new BinaryFormatter();
        //Prepare path
        string path = pathToMaps + data.mapName + ".save";
        //open stream
        FileStream stream = new FileStream(path, FileMode.Create);

        //Saving character
        formatter.Serialize(stream, data);

        stream.Close();
    }

    public static CharacterData LoadMap(string mapName)
    {
        string path = pathToMaps + mapName + ".save";
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Open);

        CharacterData data = formatter.Deserialize(stream) as CharacterData;

        stream.Close();
        return data;
    }
}
