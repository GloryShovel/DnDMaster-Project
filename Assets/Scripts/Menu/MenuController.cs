using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    /* TODO: 
     * - Convert Switcher class to work here + add stack of visited loctions to make back button work properly
     * Fancy:
     * - Multiple menu background support (switching after time / for each new menu)
     * - Make aplication use Menu background based on window size
     */

    void Start()
    {
        //Setup menu
        for(int i = 2; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}
