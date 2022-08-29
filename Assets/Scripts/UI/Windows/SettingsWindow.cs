using UnityEngine;
using UnityEngine.UI;
using UI.Windows;
using Model;

public class SettingsWindow : BaseWindow
{
    [SerializeField]
    private Slider _musicSlider;
    [SerializeField]
    private Slider _soundSlider;

    [SerializeField]
    private Toggle _fullscreenToggle;

    private SettingsModel _settingsModel => DataModel.SettingsModel;


    private void Start()
    {
        _musicSlider.value = _settingsModel.MusicVolume;
        _soundSlider.value = _settingsModel.SoundVolume;
        _fullscreenToggle.isOn = _settingsModel.IsFullScreen;

        _musicSlider.onValueChanged.AddListener(_settingsModel.ChangeMusicVolume);
        _soundSlider.onValueChanged.AddListener(_settingsModel.ChangeSoundVolume);
        _fullscreenToggle.onValueChanged.AddListener(_settingsModel.ChangeFullscreen);
    }
}
