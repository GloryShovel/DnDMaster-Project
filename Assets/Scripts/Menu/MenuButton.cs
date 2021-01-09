using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{

    public void Click()
    {
        Debug.Log("kliknięcie: " + this.name);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
