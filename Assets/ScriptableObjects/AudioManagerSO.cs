using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/AudioManagementData", order = 4)]
public class AudioManagerSO : ScriptableObject
{

    [SerializeField]
    public AudioClip bgMusic;

    [SerializeField]
    public AudioClip darkBgMusic;

    [SerializeField]
    public float volume = 1f;
}
