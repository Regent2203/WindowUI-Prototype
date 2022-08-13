using UI.Configs;
using UnityEditor;

[CustomPropertyDrawer(typeof(WindowConfig.WindowDictionary))]
public class WindowDictionaryPropertyDrawer : SerializableDictionaryPropertyDrawer { }