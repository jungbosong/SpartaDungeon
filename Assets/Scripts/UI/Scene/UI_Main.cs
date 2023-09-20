using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Main : UI_Scene
{
    #region Enums
    enum Images
    {
        PlayerImage,
    }
    enum Texts
    {
        PlayerNameText,
        PlayerLevelText,
        CoinText,
    }
    enum Buttons
    {
        
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

        return true;
    }
}
