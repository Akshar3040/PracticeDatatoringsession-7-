using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ContactPopUpScript : MonoBehaviour
{
    public Text Name,Number;
    Button click;
    Button Edit;




    private void Start()
    {
        click = GetComponent<Button>();
        Edit = GetComponent<Button>();
        click.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        SaveManager.inst.ShowContacts(this);

        UIManaager.instance.Shownextscreen(screenlist.ViewDetailsPage);
    }
}
