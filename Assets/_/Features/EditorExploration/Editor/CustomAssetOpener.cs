using EditorExploration.Runtime;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace EditorExploration.Editor
{
    public class CustomAssetOpener : EditorWindow
    {
        [MenuItem("Les Meilleurs Tools/Le Tool")]
        public static void ShowWindow()
        {
            var window = GetWindow<CustomAssetOpener>();
            window.titleContent.text = "Le Tool";
        }

        [OnOpenAsset]
        public static bool OpenAsset(int instanceId, int line)
        {
            if(Selection.activeObject is MyScriptableObject)
            {
                ShowWindow();
                return true;
            }
            return false;
        }

        private void OnGUI()
        {
            string[] guids = AssetDatabase.FindAssets("t:MyScriptableObject");


            for (int i = 0; i < guids.Length; i++)
            {
                var assetPath = AssetDatabase.GUIDToAssetPath(guids[i]);
                var currentSO = AssetDatabase.LoadAssetAtPath(assetPath, typeof(MyScriptableObject));
                GUILayout.Label($"Found:{currentSO.name}");
            }
        }
    }
}
