using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Main : UI_Scene
{
    #region Enums
    enum Images
    {
        PlayerImage,
        ExperienceValueImage,
    }
    enum Texts
    {
        JobText,
        NameText,
        LevelValueText,
        ExperienceValueText,
        CharacterDescriptionText,
        CoinText,
    }
    enum Buttons
    {
        StatusButton,
        InventoryButton,
    }
    #endregion

    private void Start()
    {
        Init();
    }

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        #region Bind
        BindImage(typeof(Images));
        BindText(typeof(Texts));
        BindButton(typeof(Buttons));
        #endregion

        #region SetUI
        GetText((int)Texts.JobText).text = Managers.UserManager.JobToString();
        GetText((int)Texts.NameText).text = Managers.UserManager.name;
        GetText((int)Texts.LevelValueText).text = Managers.UserManager.level.ToString();
        GetText((int)Texts.ExperienceValueText).text = $"{Managers.UserManager.experienceValue} / {Managers.UserManager.maxExperienceValue}";
        GetImage((int)Images.ExperienceValueImage).gameObject.GetComponent<Image>().fillAmount = (float)Managers.UserManager.experienceValue / Managers.UserManager.maxExperienceValue;
        // TODO
        GetText((int)Texts.CharacterDescriptionText).text = "직업 설명";
        GetText((int)Texts.CoinText).text = Managers.UserManager.coin.ToString();

        GetButton((int)Buttons.StatusButton).gameObject.BindEvent(OnClickedStatusButton);
        GetButton((int)Buttons.InventoryButton).gameObject.BindEvent(OnClickedInventoryButton);
        #endregion
        return true;
    }

    void OnClickedStatusButton()
    {
        Debug.Log("Status");
        Managers.UI.ShowPopupUI<UI_StatusPopup>();
    }

    void OnClickedInventoryButton()
    {
        Debug.Log("Inventory");
        Managers.UI.ShowPopupUI<UI_InventoryPopup>();
    }
}
