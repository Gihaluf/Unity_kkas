using UnityEngine;

public class SFX_Script : MonoBehaviour
{
    public AudioSource sfxSource;
    public AudioClip[] audioClips;

    public void PlaySFX(int ix)
    {
        if(sfxSource.isPlaying)
            sfxSource.Stop();

        sfxSource.PlayOneShot(audioClips[ix]);
    }
    public void PlaySFXker(int ix)
    {
        sbyte index = (sbyte)ix;
        if (index >= 0 && index < audioClips.Length)
        {
            sfxSource.PlayOneShot(audioClips[index]);
        }
        else
        {
            Debug.LogWarning("Invalid SFX index: " + ix);
        }
    }
}
