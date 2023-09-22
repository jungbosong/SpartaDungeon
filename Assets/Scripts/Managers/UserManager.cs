using ItemInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class UserManager
{
    public enum Job
    {
        WARRIOR,
        WIZARD,
        HEALER,
        TANKER,
    }
    public enum PurchaseType
    {
        NoMore,
        Success,
        LackGold,
    }

    public string name { get; set; }
    public int level {  get; set; }
    public int experienceValue { get; set; }
    public int maxExperienceValue { get; set; }
    public Job job { get; set; }
    public int hp { get; set; }
    public int atk { get; set; }
    public int def { get; set; }
    public int increasedAtk { get; set; }
    public int increasedDef { get; set; }
    public int criticalDamage { get; set; }
    public int coin { get; set; }

    public List<ItemInfo> inventory = new List<ItemInfo>();
    public int choosedItemNum;

    public void Init()
    {
        name = "User";
        level = 1;
        experienceValue = 3;
        maxExperienceValue = 10;
        job = Job.WARRIOR;
        hp = 100;
        atk = 10;
        def = 5;
        increasedAtk = 0;
        increasedDef = 0;
        criticalDamage = 35;
        coin = 1600;

        inventory = Managers.JsonReader.ReadItemDataJson("Assets/Data/itemData.json").ItemInfoList;
    }

    public void UpdateInfo()
    {
        atk = 10;
        def = 5;
        increasedAtk = 0;
        increasedDef = 0;
    }

    public string JobToString()
    {
        string result = "";
        switch (job)
        {
            case Job.WARRIOR:
                result = "Àü»ç";
                break;
            case Job.WIZARD:
                result = "¸¶¹ý»ç";
                break;
            case Job.HEALER:
                result = "Èú·¯";
                break;
            case Job.TANKER:
                result = "ÅÊÄ¿";
                break;
        }
        return result;
    }
}