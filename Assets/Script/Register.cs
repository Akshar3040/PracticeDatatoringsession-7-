using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Register : MonoBehaviour
{
    public Button submit;

    [SerializeField]public  TMP_InputField userid;
    [SerializeField]public  TMP_InputField password;
    [SerializeField]public  TMP_InputField fullname;
    [SerializeField]public  TMP_InputField contactnumber;



    private void Start()
    {
        submit.onClick.AddListener(onsubmit);
    }


    public void onsubmit()

    {
        // InputHandler.inst.AddNameToList(this);
        SaveManager.inst.RegistrationData(userid.text,password.text,fullname.text, contactnumber.text);

        UIManaager.instance.Shownextscreen(screenlist.loginpage);
       
        
    }

    


}
