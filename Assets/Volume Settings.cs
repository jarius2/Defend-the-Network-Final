using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
   [SerializeField] private AudioMixer myMixer;
   [SerializeField] private Slider musicSlider; 

    private void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadVolume();
        }
        else
        {
            LoadVolume();
        }
    
    }
    public void SetMusicVolume()
    {
        float volume = musicSlider.value;
        myMixer.SetFloat("music", Mathf.Log10(volume)*20    );
        PlayerPrefs.SetFloat("musicVolume", volume);
        SaveVolume();
    }

    private void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void SaveVolume()
    {
        PlayerPrefs.SetFloat("musicVolume", musicSlider.value);
    }
}
