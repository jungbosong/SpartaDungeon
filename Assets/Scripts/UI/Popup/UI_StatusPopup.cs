using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class UI_StatusPopup : UI_Popup
{
    const int INFO_COUNT = 4;
    #region enums
    enum GameObjects
    {
        InfoPanel,
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

        for (int i = 0; i < INFO_COUNT; i++)
        {
            GameObject item = Managers.UI.MakeSubItem<UI_InfoItem>(GetObject((int)GameObjects.InfoPanel).transform, "InfoItem").gameObject;
            UI_InfoItem infoItem = item.GetOrAddComponent<UI_InfoItem>();
            if (infoItem.Init())
                infoItem.SetInfo(i);
        }

        return true;
    }

    void OnClickedCloseButton()
    {
        Debug.Log("Cicked CloseButton");
        Managers.UI.ClosePopupUI(this);
    }
}