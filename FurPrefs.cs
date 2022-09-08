using Newtonsoft.Json;
using UnityEngine;
public class FurPrefs : MonoBehaviour
{
   public static void SaveData(ExampleClass Data,string DataId)
   {
      string json = JsonConvert.SerializeObject(Data);
      PlayerPrefs.SetString(DataId,json);
      print("Data Saved");
   }
   public static T GetData<T>(string DataId)
   {
      string json = PlayerPrefs.GetString(DataId, "null");
      print("Data Data Loaded");
      return JsonConvert.DeserializeObject<T>(json);
   }
}
