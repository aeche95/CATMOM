using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/UIManagementData", order = 3)]
public class UIManagerSO : ScriptableObject
{
    [SerializeField]
    public Texture2D cursor;

    [SerializeField]
    public CursorMode cursorMode;

    [SerializeField]
    public Vector2 cursorOffset;
    
}
