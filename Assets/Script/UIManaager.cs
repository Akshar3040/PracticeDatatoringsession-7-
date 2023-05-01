using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;

public class UIManaager : MonoBehaviour
{
    public List<BaseClass> screenlist;
    BaseClass currentscreen;

    public static UIManaager instance;
        private void Awake()
    {
        instance = this;
        currentscreen = screenlist[0];


    }


    public void Shownextscreen(screenlist Screen)
    {
        currentscreen.offCanvas();
        screenlist[(int)Screen].OnCanvas();
        currentscreen = screenlist[(int)Screen];

    }
}
