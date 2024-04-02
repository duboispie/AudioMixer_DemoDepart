using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    [SerializeField] private Slider volumeMusiqueSlider;

    [SerializeField] private Slider volumeEffetSlider;


    private AudioSource audioSource;


    void Start() {
        audioSource = GetComponent<AudioSource>();

        // audioMixer.GetFloat("VolumeMusique")

        // audioMixer.SetFloat("VolumeMusique", -20f);
    }

    public void AjusteVolumeMusique(float volume){
        audioMixer.SetFloat("VolumeMusique", ConvertToLog(volume));
    }

     public void AjusteVolumeEffet(float volume){
        audioMixer.SetFloat("VolumeEffet", ConvertToLog(volume));
        audioSource.Play();
    }

    private float ConvertToLog(float volume){
        return Mathf.Log10(volume) * 20;
    }
}
