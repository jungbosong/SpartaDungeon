using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }

    public void UpdateInfo()
    {
        atk = 10;
        def = 5;
        increasedAtk = 0;
        increasedDef = 0;
        //SetIncreasedAtk();
        //SetIncreasedDef();
    }

    /*public void SetIncreasedAtk()
    {
        foreach (Item item in inventory.items)
        {
            if (item.equipped)
            {
                if (item.type == (int)ItemType.AttackItem)
                {
                    increasedAtk += item.effect;
                    atk += increasedAtk;
                    equippedAtkItems.Add(item.name);
                }
            }
            else if (equippedAtkItems.Contains(item.name))
            {
                equippedAtkItems.Remove(item.name);
                increasedAtk -= item.effect;
                atk -= increasedAtk;
            }
        }
    }

    public void SetIncreasedDef()
    {
        foreach (Item item in inventory.items)
        {
            if (item.equipped)
            {
                if (item.type == (int)ItemType.DefensiveItem)
                {
                    increasedDef += item.effect;
                    def += increasedDef;
                    equippedDefItems.Add(item.name);
                }
            }
            else if (equippedAtkItems.Contains(item.name))
            {
                equippedDefItems.Remove(item.name);
                increasedDef -= item.effect;
                def -= increasedDef;
            }
        }
    }

    public void EquipItem(int idx)
    {
        if (inventory.items[idx].type == (int)ItemType.AttackItem)
        {
            if (atkItem == null)
            {
                atkItem = inventory.items[idx];
            }
            if (atkItem.name != inventory.items[idx].name)
            {
                if (atkItem.equipped)
                {
                    atkItem.Equip();
                }
                atkItem = inventory.items[idx];
            }
            atkItem.Equip();
        }
        else
        {
            if (defItem == null)
            {
                defItem = inventory.items[idx];
            }
            if (defItem.name != inventory.items[idx].name)
            {
                if (defItem.equipped)
                {
                    defItem.Equip();
                }
                defItem = inventory.items[idx];
            }
            defItem.Equip();
        }
    }*/

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
