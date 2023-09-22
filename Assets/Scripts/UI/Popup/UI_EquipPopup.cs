using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_EquipPopup : UI_Popup
{
    bool isEquipped;
    #region enums
    enum Texts
    {
        QuestionText,
    }
    enum Buttons
    {
        DoButton,
        CancelButton,
    }
    #endregion

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        #region Bind
        BindText(typeof(Texts));
        BindButton(typeof(Buttons));
        #endregion

        isEquipped = Managers.UserManager.inventory[Managers.UserManager.choosedItemNum].IsEquiped;
        GetText((int)Texts.QuestionText).text = isEquipped ? "���� �����Ͻðڽ��ϱ�?" : "���� �Ͻðڽ��ϱ�?";
        GetButton((int)Buttons.DoButton).gameObject.BindEvent(OnClickedDoButton);
        GetButton((int)Buttons.CancelButton).gameObject.BindEvent(Managers.UI.ClosePopupUI);

        return true;
    }

    void OnClickedDoButton()
    {
        Managers.UserManager.inventory[Managers.UserManager.choosedItemNum].IsEquiped = !isEquipped;
        GameObject.Find("UI_InventoryPopup").GetComponent<UI_InventoryPopup>().RefreshUI();
        Managers.UI.ClosePopupUI(this);
    }
}
