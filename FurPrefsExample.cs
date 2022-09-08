using UnityEngine;
using UnityEngine.UI;
public class FurPrefsExample : MonoBehaviour
{
    public InputField id;
    public InputField name;
    public InputField surname;
    public InputField getid;
    public InputField getname;
    public InputField getsurname;
    public void SaveData()
    {
        ExampleClass cls = new ExampleClass();
        cls.ExampleName = name.text;
        cls.ExampleSurname = surname.text;
        FurPrefs.SaveData(cls, id.text);


    }
    public void GetData()
    {
        var cls =FurPrefs.GetData<ExampleClass>(getid.text);
        if (cls == null)
        {
            getname.text = "Null";
            getsurname.text = "Null";
            return;
        }
        print(cls.ExampleName);
        print(cls.ExampleSurname);
        getname.text = cls.ExampleName;
        getsurname.text = cls.ExampleSurname;
    }
}