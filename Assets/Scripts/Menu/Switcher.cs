using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : MonoBehaviour
{
    /*TEMP SOLUTION!!!
     * Store:
     * - UI elements refrences
     * - stack of visited elements
     * 
     * Methods:
     * - back() - backing up in stack of visited elements
     * - goto(GameObject obj) - sets inactive this object and sets active obj
     */
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
