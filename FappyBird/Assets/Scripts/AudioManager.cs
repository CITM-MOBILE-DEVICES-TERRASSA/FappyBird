using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource SFXsource;

    public AudioClip swoosh;
    public AudioClip hit;
    public AudioClip fly;
    public AudioClip die;
    public AudioClip score;

    private void Start()
    {
        
    }
    public void PlaySFX(AudioClip clip)
    {
        SFXsource.PlayOneShot(clip);
    }
}
