using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItemInformation;
using UnityEditor.UIElements;

public class UI_Item : UI_Base
{      
    #region enums
    enum GameObjects
    {
        EquipedMark,
    }
    enum Images
    {
        ItemImage,
    }
    #endregion
    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        #region Bind
        BindObject(typeof(GameObjects));
        BindImage(typeof(Images));
        #endregion
        
        return true;
    }

    public void SetInfo(int itemNum)
    {
        ItemInfo item = Managers.UserManager.inventory[itemNum];
        GetImage((int)Images.ItemImage).sprite = Resources.LoadAll<Sprite>(item.ImgPath)[item.ImgNum];
        GetImage((int)Images.ItemImage).gameObject.BindEvent(() => OnClickedItem(itemNum));
        GetObject((int)GameObjects.EquipedMark).SetActive(item.IsEquiped);
    }

    void OnClickedItem(int itemNum)
    {
        Managers.UserManager.choosedItemNum = itemNum;
        Managers.UI.ShowPopupUI<UI_EquipPopup>();
    }
}
