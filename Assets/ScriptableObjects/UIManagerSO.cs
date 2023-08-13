using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/UIManagementData", order = 3)]
public class UIManagerSO : ScriptableObject
{
    [SerializeField]
    public Texture2D normalCursor;

    [SerializeField] 
    public Texture2D clickingCursor;

    [SerializeField]
    public CursorMode cursorMode;

    [SerializeField]
    public Vector2 cursorOffset;

    [SerializeField]
    public bool isPaused = false;

    private void Awake()
    {
        isPaused = false;
    }

}
