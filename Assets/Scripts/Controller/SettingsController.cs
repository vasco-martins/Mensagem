using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{

    public AudioMixer AudioMixer;

    public float CurrentVolume { get; set; }

    public Slider VolumeSlider { get; set; }

    // Start is called before the first frame update
    void Start()
    {

        // Get Components
        VolumeSlider = GameObject.Find("General Volume Slider").GetComponent<Slider>();

        // Initialize Default Values
        CurrentVolume = PlayerPrefs.GetFloat("Volume Preference");

        VolumeSlider.value = CurrentVolume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMainVolume()
    {
        float value = VolumeSlider.value;
        
        Debug.Log("[SettingsController] Changing volume to" + value);

        AudioMixer.SetFloat("Master Volume", value);
        PlayerPrefs.SetFloat("Volume Preference", value);
    }
}
