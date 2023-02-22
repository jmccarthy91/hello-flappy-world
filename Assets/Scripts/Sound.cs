using UnityEngine.Audio;
using UnityEngine;


[System.Serializable]
public class Sound          //creating class sound to enable my AudioManager
{
    public string name;

    public AudioClip clip;
    
    [Range(0f, 1f)]
    public float volume;
    [Range(.1f, 3f)]
    public float pitch;     //friendly reminder to always set this to 1 (default is 0)

    public bool loop;

    [HideInInspector]
    public AudioSource source;

}
