using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using ItemInformation;

public class JsonReader
{
    public ItemData ReadItemDataJson(string path)
    {
        string json = File.ReadAllText(path);
        return JsonUtility.FromJson<ItemData>(json);
    }
}