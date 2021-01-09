using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : MonoBehaviour
{
    GameObject me;

    private void Start()
    {
        me = this.gameObject;
    }

    public void Switch(GameObject whichOne)
    {
        me.SetActive(false);
        whichOne.SetActive(true);
    }




}
