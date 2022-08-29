using UnityEditor;
using UnityEngine;
using Configs;

namespace Editor
{
    public static class ConfigsCreation
    {
        [MenuItem("Tools/Create WindowConfig")]
        static void CreateWindowConfig()
        {
            var asset = ScriptableObject.CreateInstance<WindowConfig>();

            AssetDatabase.CreateAsset(asset, "Assets/Configs/WindowConfig.asset");
            AssetDatabase.SaveAssets();

            Selection.activeObject = asset;
        }
    }
}