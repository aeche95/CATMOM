using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SceneManagementData", order = 2)]
public class SceneManagementSO : ScriptableObject
{
    [SerializeField]
    public int currentSceneIndex = 0;

    [SerializeField]
    public string[] playableScenes;
}
