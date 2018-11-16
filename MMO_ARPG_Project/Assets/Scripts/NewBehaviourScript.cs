using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Use this for initialization
    void Start ()
    {
        UIMgr.Instance.ShowForms<StartWnd>(StartWnd.FormsName, false);
	}

}
