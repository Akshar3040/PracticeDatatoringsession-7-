using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Username : MonoBehaviour
{
   public Button addnew;
    //public Button view;

    public Text userName;

    public static Username inst;

    private void Start()
    {
        addnew.onClick.AddListener(onaddnew);
       // view.onClick.AddListener(onsave);

         }

    private void Awake()
    {
        inst = this;
    }

    public void onaddnew()
    {
        UIManaager.instance.Shownextscreen(screenlist.CreateNewContactPage);
        
    }

   // public void onsave()
   // {
   //     UIManaager.instance.Shownextscreen(screenlist.UserNamepage);
   // }

}
