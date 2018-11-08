using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 窗体的抽象基类
/// </summary>
[RequireComponent(typeof(UIPanel))]
public abstract class UIBaseForms<T> : MonoBehaviour
{
    [Header("窗口类型")]
    public UIFormsType mFormsType = UIFormsType.Normal;

    [Header("窗口生命类型")]
    public UIFormsLifeType mFormsLifeType = UIFormsLifeType.HumanLife;

    [Header("窗口层级类型")]
    public UIFormsLayer mFormsLayerType = UIFormsLayer.CommonUILayer;

    /// <summary>
    /// 窗口名
    /// </summary>
    public static readonly string FormsName = typeof(T).Name;

    /// <summary>
    /// 第一次创建窗口时调用
    /// </summary>
    public abstract void Show();

    /// <summary>
    /// 隐藏
    /// </summary>
    public virtual void Hide()
    {
        gameObject.SetActive(false);
    }

    /// <summary>
    /// 再次显示
    /// </summary>
    public virtual void ReShow()
    {
        gameObject.SetActive(true);
    }

    /// <summary>
    /// 结束-在销毁之前调用
    /// </summary>
    public virtual void End()
    {

    }


}
