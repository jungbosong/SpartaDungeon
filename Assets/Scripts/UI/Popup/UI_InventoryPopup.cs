using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_InventoryPopup : UI_Popup
{
    #region enums
    enum GameObjects
    {
        Content,
    }
    enum Buttons
    {
        CloseButton,
    }
    #endregion

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        #region Bind
        BindObject(typeof(GameObjects));
        BindButton(typeof(Buttons));
        #endregion

        GetButton((int)Buttons.CloseButton).gameObject.BindEvent(OnClickedCloseButton);

        RefreshUI();

        return true;
    }

    public void RefreshUI()
    {
        foreach (Transform child in GetObject((int)GameObjects.Content).transform)
            Managers.Resource.Destroy(child.gameObject);

        for (int i = 0; i < Managers.UserManager.inventory.Count; i++)
        {
            GameObject itemObj = Managers.UI.MakeSubItem<UI_Item>(GetObject((int)GameObjects.Content).transform, "Item").gameObject;
            UI_Item item = itemObj.GetOrAddComponent<UI_Item>();
            if (item.Init())
                item.SetInfo(i);
        }
    }

    void OnClickedCloseButton()
    {
        Debug.Log("Cicked CloseButton");
        Managers.UI.ClosePopupUI(this);
    }
}