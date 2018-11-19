using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Text;

public class AssetBundleEditor : EditorWindow
{
    [MenuItem("Tools/AssetBundle")]
    private static void CreateWindow()
    {
        AssetBundleEditor wnd = EditorWindow.GetWindow<AssetBundleEditor>(true);
        wnd.minSize = new Vector2(500, 780);
        wnd.Show();
    }

    private void OnGUI()
    {
    }
}
