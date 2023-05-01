using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

using System.IO;


public class SaveManager : MonoBehaviour
{
    [SerializeField] public bool isvalid; 
    public AppData appData;
    //public ContactList contacts1;
    [SerializeField]GameObject prefabeContact;
    [SerializeField] GameObject parentContent;
    string storeName, storeNum;


    public static SaveManager inst;
    private void Awake()
    {
        inst = this;
        LoadData();
    }

    public void RegistrationData(string username, string pass, string name, string number)
    {
        UserData userData = new UserData();

        userData.userId = username;
        userData.password = pass;
        userData.FullName = name;
        userData.MobileNumber = number;
        userData.contactList = new ContactList();
        appData.users.Add(userData);
        SaveData();        
    }

    public void ContactData(string Name, string Number)
    {
         Contacts contacts = new Contacts();  
        contacts.ContactNmae = Name;
        contacts.ContactNumber = Number;
        UserData cureentuser =  appData.users.Find(u => u.userId == Login.inst.Userlogin.text);
        if (cureentuser != null)
        {
            cureentuser.contactList.contacts.Add(contacts);
        }
        SaveData();
    }


    public void SaveData()
    {
        File.WriteAllText(Application.dataPath + "/Data/data.json", JsonUtility.ToJson(appData));
    }

    public void LoadData ()
    {
        appData = JsonUtility.FromJson<AppData>(File.ReadAllText(Application.dataPath + "/Data/data.Json"));
    }

    public void loginvalidation()
    {
        UserData CurrentUser = appData.users.Find(u => u.userId == Login.inst.Userlogin.text && u.password ==Login.inst.passwordlogin.text);
        if (CurrentUser != null ) //&& CurrentUser.password == Login.inst.passwordlogin.text) 
        {
             isvalid = true;
            Username.inst.userName.text = CurrentUser.userId;
            DisplayContactPrefabe();
             }
             else
             {
                 isvalid = false;
             }
        }
    public void Constactinstance(string Name, string Number)
    {
        GameObject game = Instantiate(prefabeContact, parentContent.transform);
        ContactPopUpScript script = game.GetComponent<ContactPopUpScript>();

        script.Name.text = Name;
        script.Number.text = Number;
    }


    public void DisplayContactPrefabe()
    {

        UserData CurrentUser = appData.users.Find(u => u.userId == Login.inst.Userlogin.text && u.password == Login.inst.passwordlogin.text);
        int count = CurrentUser.contactList.contacts.Count;
        for(int i = 0; i<count;i++)
        {
            GameObject game = Instantiate(prefabeContact, parentContent.transform);
            ContactPopUpScript script = game.GetComponent<ContactPopUpScript>();

            script.Name.text = CurrentUser.contactList.contacts[i].ContactNmae;
            script.Number.text = CurrentUser.contactList.contacts[i].ContactNumber;
        }
    }

    public void EditContact()
    {
        
    }

    public void ShowContacts(ContactPopUpScript contact)

    {
        storeName = contact.Name.text;
        storeNum = contact.Number.text;
        ViewDetail.inst.ViewName.text = contact.Name.text;
        ViewDetail.inst.ViewContact.text = contact.Number.text;

    }





    }
[System.Serializable]
public class AppData
{
   public List<UserData> users = new List<UserData>();

}
[System.Serializable]
public class UserData
{
    public string userId;
    public string password;
    public string FullName;
    public string MobileNumber;

    public ContactList contactList  = new ContactList();
}
[System.Serializable]
public class ContactList
{
    public List<Contacts> contacts = new List<Contacts>();
}



[System.Serializable]
public class Contacts
{
    public string ContactNmae;
    public string ContactNumber;
}