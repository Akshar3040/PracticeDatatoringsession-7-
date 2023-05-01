using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ViewDetail : MonoBehaviour
{
    public Button save;
    public TMP_InputField ViewName;
    public TMP_InputField ViewContact;

    public static ViewDetail inst;
    private void Awake()
    {
        inst = this;
    }


    private void Start()
    {
        save.onClick.AddListener(onsave);   
    }

    public void onsave()
    {

        UIManaager.instance.Shownextscreen(screenlist.UserNamepage);
    }
}
