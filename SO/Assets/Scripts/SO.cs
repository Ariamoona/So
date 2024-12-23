using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AudioSettings", menuName = "ScriptableObjects/AudioSettings")]
public class AudioSettings : ScriptableObject
{
    public string uniqueID; 
    [TextArea(3, 10)]
    public string longText; 

    public AudioClipData[] audioClips;
    internal AudioContentType audioContentType;
}