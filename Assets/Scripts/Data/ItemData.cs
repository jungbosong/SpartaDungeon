using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemInformation
{
    [System.Serializable]
    public class ItemInfo
    {
        public string ImgPath;
        public int ImgNum;
        public string Name;
        public float Eft;
        public bool IsEquiped;
    }

    [System.Serializable]
    public class ItemData
    {
        public List<ItemInfo> ItemInfoList;
    }
}