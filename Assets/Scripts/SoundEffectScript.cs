using UnityEngine;

public class SoundEffectScript : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClips;

    public void PlaySFX (int ix)
    {
        if (audioSource.isPlaying)
            audioSource.Stop();
        else
            audioSource.PlayOneShot(audioClips[ix]);
    }
}
