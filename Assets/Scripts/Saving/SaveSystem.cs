using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    //NOTE: We might think about making monsters and NPCs as well as characters from program
    //      or just switch this to javascript (because dnd allows to make custom made things)

    static string pathToCharacters = Application.persistentDataPath + "/Characters/";
    static string pathToMaps = Application.persistentDataPath + "/Maps/";
    static string pathToMapsImages = Application.persistentDataPath + "/MapsImages/";
    static string pathToSessions = Application.persistentDataPath + "/Sessions/";

    //TODO: Redo this to make file checking at start of program
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
        CheckDirectory(pathToCharacters);

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
        CheckDirectory(pathToMapsImages);

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

    public static MapData LoadMap(string mapName)
    {
        CheckDirectory(pathToMaps);

        string path = pathToMaps + mapName + ".save";
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Open);

        MapData data = formatter.Deserialize(stream) as MapData;

        stream.Close();
        return data;
    }

    //--------------------------Session-----------------------------------------------
    public static void SaveSession(Session session)
    {
        CheckDirectory(pathToSessions);

        SessionData data = new SessionData(session);

        //Setup formatter
        BinaryFormatter formatter = new BinaryFormatter();
        //Prepare path
        string path = pathToSessions + data.sessionName + ".save";
        //open stream
        FileStream stream = new FileStream(path, FileMode.Create);

        //Saving character
        formatter.Serialize(stream, data);

        stream.Close();
    }

    public static SessionData LoadSession(string sesstionName)
    {
        CheckDirectory(pathToSessions);

        string path = pathToSessions + sesstionName + ".save";
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Open);

        SessionData data = formatter.Deserialize(stream) as SessionData;

        stream.Close();
        return data;
    }
}
