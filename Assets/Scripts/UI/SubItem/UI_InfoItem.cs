using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UI_InfoItem : UI_Base
{
    const string IMG_PATH = "Sprites/Steampunk_UI_inventory_cursor_icons";
    int[] imgNums = { 21, 22, 25, 28 };

    #region enums
    enum Images
    {
        InfoImage,
    }
    enum Texts
    {
        InfoNameText,
        InfoValueText,
    }
    #endregion
    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        #region Bind
        BindImage(typeof(Images));
        BindText(typeof(Texts));
        #endregion

        return true;
    }

    public void SetInfo(int itemNum)
    {
        Debug.Log(IMG_PATH + itemNum);
        Debug.Log(Resources.LoadAll<Sprite>(IMG_PATH)[imgNums[itemNum]]);
        GetImage((int)Images.InfoImage).sprite = Resources.LoadAll<Sprite>(IMG_PATH)[imgNums[itemNum]];
        string name = "";
        string value= "";
        switch(itemNum)
        {
            case 0:
                name = "공격력";
                value = Managers.UserManager.atk.ToString();
                break;
            case 1:
                name = "방어력";
                value = Managers.UserManager.def.ToString();
                break;
            case 2:
                name = "체력";
                value = Managers.UserManager.hp.ToString();
                break;
            case 3:
                name = "치명타";
                value = Managers.UserManager.criticalDamage.ToString();
                break;
        }
        GetText((int)Texts.InfoNameText).text = name;
        GetText((int)Texts.InfoValueText).text = value;
    }
}
