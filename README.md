# FurPrefs

## Unity Class save system 


### Save Data

```
FurPrefs.SaveData(class, id);
```

### Load Data

```
var cls =FurPrefs.GetData<Class>(id);
```

### Example Usage


#### Class:

```
using System;
[Serializable]
public class ExampleClass
{
    public string ExampleName { get; set; }
    public string ExampleSurname { get; set; }
}
```


#### Save Data:

```
public void SaveData(string id,string name,string surname)
{
    ExampleClass cls = new ExampleClass();
    cls.ExampleName = name;
    cls.ExampleSurname = surname;
    FurPrefs.SaveData(cls, id);
}
```

#### Load Data:

```
public void GetData(string id)
{
    var cls =FurPrefs.GetData<ExampleClass>(id);
    if (cls == null)
    {
        return;
    }
    print(cls.ExampleName);
    print(cls.ExampleSurname);
}
```

   
