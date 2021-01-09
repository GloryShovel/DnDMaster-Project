using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session : MonoBehaviour
{
    public List<Map> maps;

    public Session(List<Map> maps)
    {
        this.maps = maps;
    }

}
