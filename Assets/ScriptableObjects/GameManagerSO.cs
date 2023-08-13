using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/GameManagementData", order = 1)]
public class GameManagerSO : ScriptableObject
{
    [SerializeField]
    public int days = 0;

    [SerializeField]
    public int health = 100;

    [SerializeField]
    public bool isAbandoned = false;
    
}
