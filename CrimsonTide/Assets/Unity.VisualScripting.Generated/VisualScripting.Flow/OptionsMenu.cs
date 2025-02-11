using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Slider VolumeSlider;
    public Toggle FullScreenToggle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        VolumeSlider.value = PlayerPrefs.GetFloat("Volume", 1.0f);
        FullScreenToggle.isOn = PlayerPrefs.GetInt("Fullscreen", 1) == 1;

        AudioListener.volume = VolumeSlider.value;
        Screen.fullScreen = FullScreenToggle.isOn;
    }
    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
        PlayerPrefs.SetFloat("Volume", volume);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen= isFullscreen;
        PlayerPrefs.SetInt("Fullscreen", isFullscreen ? 1 : 0);
    }
}
