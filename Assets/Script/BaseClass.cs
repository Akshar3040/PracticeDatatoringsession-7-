using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BaseClass : MonoBehaviour
{
    [HideInInspector] private Canvas canvas;


    private void Awake()
    {
        canvas = GetComponent<Canvas>();
    }


    public void OnCanvas()
    {
        canvas.enabled = true;
    }

    public void offCanvas()
    {
        canvas.enabled = false;
    }
    
        
  


}

public enum screenlist
{
    loginpage,
    Registration,
    UserNamepage,
    CreateNewContactPage,
    ViewDetailsPage,
    
}


