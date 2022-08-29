using UnityEngine;
using UnityEditor;
using Configs;
using UI.Windows;
using Model;

public class Entry : MonoBehaviour
{
    [Header("Configs")]
    [SerializeField]
    private WindowConfig _windowConfig;


    private void Awake()
    {
        if (_windowConfig == null)
        {
            Debug.LogWarning($"{nameof(Entry)} gameobject has unassigned {nameof(WindowConfig)} link, please fix", this);
            _windowConfig = AssetDatabase.LoadAssetAtPath<WindowConfig>("Assets/Configs/WindowConfig.asset");
        }

        var dataModel = new DataModel();
        var windowManager = new WindowManager(_windowConfig);

        BaseWindow.DataModel = dataModel;
        BaseWindow.WindowManager = windowManager;
    }

    private void Start()
    {
        //Start
        BaseWindow.WindowManager.ShowWindow(WndId.Preloader);
    }
}
