using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class AddNewcontact : MonoBehaviour
{
   public Button save;

    public TMP_InputField ContactNumber;
    public TMP_InputField Contatcname;

    private void Start()
    {
       save.onClick.AddListener(onsave);
    }

    public void onsave()
    {
        Debug.Log("Contactsaved");
        SaveManager.inst.ContactData(Contatcname.text, ContactNumber.text);

        SaveManager.inst.Constactinstance(Contatcname.text, ContactNumber.text);
        UIManaager.instance.Shownextscreen(screenlist.UserNamepage);
    }

}
