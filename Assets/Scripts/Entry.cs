using UnityEngine;
using UnityEditor;
using UI.Configs;
using Model;

public class Entry : MonoBehaviour
{
    [Header("Configs")]
    [SerializeField]
    private WindowConfig _windowConfig;

    [Space]
    [SerializeField]
    private Canvas _canvas;


    private DataModel _dataModel;


    private void Awake()
    {
        if (_windowConfig == null)
        {
            Debug.LogWarning($"{nameof(Entry)} gameobject has unassigned {nameof(WindowConfig)} link, please fix", this);
            _windowConfig = AssetDatabase.LoadAssetAtPath<WindowConfig>("Assets/Configs/WindowConfig.asset");
        }
    }

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        _dataModel = new DataModel(_windowConfig, _canvas);
    }
}
