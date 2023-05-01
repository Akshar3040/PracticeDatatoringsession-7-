using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Login : MonoBehaviour
{
    public Button registerbtn;
    public Button loginbtn;

    public TMP_InputField Userlogin;
    public TMP_InputField passwordlogin;

    public static Login inst;

    private void Start()
    {
        loginbtn.onClick.AddListener(logbtn);
        registerbtn.onClick.AddListener(regibtn);

        
    }

    private void Awake()
    {
        inst = this;
    }



    public void logbtn()
    {
        // InputHandler.inst.loginmatch();
        // if (InputHandler.inst.isvalid)

        SaveManager.inst.loginvalidation();
        if (SaveManager.inst.isvalid)
            UIManaager.instance.Shownextscreen(screenlist.UserNamepage);
    }

    public void regibtn()
    {
        UIManaager.instance.Shownextscreen(screenlist.Registration);


    }

   
}
