using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("--------Audio Source---------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("--------Audio Source---------")]
    public AudioClip Background;
    public AudioClip jumpSound;
    public AudioClip attackSound;
    private void Start()
    {
        musicSource.clip = Background;
        musicSource.Play();
    }
    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);

    }
}
