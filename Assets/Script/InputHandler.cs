//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using TMPro;
//using System;
//using System.IO;

//public class InputHandler : MonoBehaviour
//{

//    [SerializeField] public TMP_InputField useridlogin;
//    [SerializeField] public TMP_InputField passwordlogin;
//    public bool isvalid;

//    public static InputHandler inst;


//    public  DataHandler dataHandler;
    

//   public void loginmatch ()
//   {
//       Dataclass Currentuser = dataHandler.dt.Find(u => u.Userid == useridlogin.text);
//       if (Currentuser != null && Currentuser.Password == passwordlogin.text)
//       {
//           isvalid = true;
//       }
//       else
//       {
//           isvalid = false;
//       }
//    }


//    private void Start()
//    {
//        dataHandler = JsonUtility.FromJson <DataHandler>(File.ReadAllText(Application.dataPath + "/Data/data.Json"));
//        inst = this;
//    }

//    public void AddNameToList(Register register)
//    {
//         Dataclass obj = new();
//        obj.Userid = register.userid.text;
//        obj.Password = register.password.text;
//        obj.Fullname = register.fullname.text;
//        obj.Mobilenumber = register.contactnumber.text;

//        dataHandler.dt.Add(obj);

//        File.WriteAllText(Application.dataPath + "/Data/data.Json", JsonUtility.ToJson(dataHandler));

//    }
//}

//[Serializable]
//public class DataHandler
//{
//  public List <Dataclass> dt = new();  
    
//}

//[Serializable]
//public class Dataclass
//{
//    public string Userid;
//    public string Password;
//    public string Fullname;
//    public string Mobilenumber;

//}