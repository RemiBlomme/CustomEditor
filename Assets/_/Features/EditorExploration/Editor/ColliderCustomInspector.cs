using UnityEditor;
using UnityEngine;

namespace EditorExploration.Editor
{
    [CustomEditor(typeof(BoxCollider))]
    public class ColliderCustomInspector : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            if (GUILayout.Button("Ceci est un button"))
            {
                CustomAssetOpener.ShowWindow();
            }
            DrawDefaultInspector();
        }
    }
}
