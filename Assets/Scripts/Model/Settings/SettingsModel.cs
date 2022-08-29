using System;
using UnityEngine;

namespace Model
{
    public class SettingsModel : IModel
    {
        public float MusicVolume { get; protected set; } = 1;
        public float SoundVolume { get; protected set; } = 1;
        public bool IsFullScreen { get; protected set; } = false;

        private const string labelMusicVolume = "musicVolume";
        private const string labelSoundVolume = "soundVolume";
        private const string labelFullscreen = "fullScreen";

        public event Action MusicVolumeChanged;
        public event Action SoundVolumeChanged;
        public event Action FullscreenModeChanged;
        public event Action ModelUpdated;

        public SettingsModel()
        {
            Init();
        }

        public void ChangeMusicVolume(float value)
        {
            MusicVolume = Mathf.Max(0, Mathf.Min(1, value));
            PlayerPrefs.SetFloat(labelMusicVolume, MusicVolume);

            MusicVolumeChanged?.Invoke();
        }

        public void ChangeSoundVolume(float value)
        {
            SoundVolume = Mathf.Max(0, Mathf.Min(1, value));
            PlayerPrefs.SetFloat(labelSoundVolume, SoundVolume);

            SoundVolumeChanged?.Invoke();
        }

        public void ChangeFullscreen(bool value)
        {
            IsFullScreen = value;
            PlayerPrefs.SetInt(labelFullscreen, IsFullScreen ? 1 : 0);

            FullscreenModeChanged?.Invoke();
        }

        public void Init()
        {
            MusicVolume = PlayerPrefs.GetFloat(labelMusicVolume, 1);
            SoundVolume = PlayerPrefs.GetFloat(labelSoundVolume, 1);
            IsFullScreen = PlayerPrefs.GetInt(labelFullscreen, 0) != 0;
        }
    }
}