/// <summary>
/// StartWnd.cs
/// Created by zhangwm 2018/11/9
///
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class StartWnd : UIBaseForms<StartWnd>
{
    #region 内部函数

    private void Start()
    {
        Init();
    }

    public override void Init()
	{
		Show();

		RegisterEvent();
	}

	private void RegisterEvent()
	{
        UIEventListener.Get(mAccountBtn).onClick = OnClickAccount;
        UIEventListener.Get(mSectionBtn).onClick = OnClickSection;
        UIEventListener.Get(mGotoGameBtn).onClick = OnClickGotoGame;
    }

	public override void Show()
	{
	}

	private void OnClickAccount(GameObject go)
	{
        NIDebug.Log("==OnClickAccount=");
	}

    private void OnClickSection(GameObject go)
    {
        NIDebug.Log("==OnClickSection=");
    }

    private void OnClickGotoGame(GameObject go)
    {
        NIDebug.Log("==OnClickGotoGame=");
    }

    #endregion

    #region 公共函数
    #endregion
}
