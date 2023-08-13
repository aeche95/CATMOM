using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Rompecabezas : MonoBehaviour
{
    [SerializeField]
    string pieceTagName;

    [SerializeField]
    GameObject selectedPiece;

    [SerializeField]
    GraphicRaycaster raycaster;

    [SerializeField]
    GameObject eventSystemHolder;

    EventSystem eventSystem;

    [SerializeField]
    GameObject[] pieces = new GameObject[16];

    [SerializeField]
    Vector3[] positions = new Vector3[16];

    [SerializeField]
    bool[] activePieces = new bool[16];

    [SerializeField]
    int horizontalRange;

    [SerializeField]
    int verticalRange;

    [SerializeField]
    float toleranceValue;

    // Start is called before the first frame update
    void Start()
    {
        raycaster = GetComponent<GraphicRaycaster>();
        eventSystem = eventSystemHolder.GetComponent<EventSystem>();
       if(this.gameObject.activeSelf)
        {
            this.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            PointerEventData pointerEventData = new PointerEventData(eventSystem);
            pointerEventData.button = PointerEventData.InputButton.Left;
            pointerEventData.position = Input.mousePosition;
            List<RaycastResult> raycastResults = new List<RaycastResult>();
            raycaster.Raycast(pointerEventData, raycastResults);

            if (raycastResults.Count > 0)
            {
                foreach(RaycastResult result in raycastResults )
                {
                    if(result.gameObject.CompareTag(pieceTagName))
                    {
                        int pieceIndex = System.Array.IndexOf(pieces, result.gameObject);
                        if (pieceIndex != -1 && activePieces[pieceIndex] && selectedPiece == null)
                        {
                            selectedPiece = result.gameObject;
                            break;
                        }
                    }
                }
                
            }

            if (selectedPiece != null)
            {
               
                Vector3 piecePosition = Input.mousePosition;
                piecePosition.z = 0;
                selectedPiece.transform.position = piecePosition;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if(CheckPiecePosition(selectedPiece))
            {
                SetCorrectPiece(selectedPiece);
            }
            if(CheckFinishPuzzle())
            {
                FinishPuzzle();
            }
            selectedPiece = null;
        }
    }

    bool CheckPiecePosition(GameObject piece)
    {
        int pieceIndex = System.Array.IndexOf(pieces, piece);
        if (pieceIndex != -1 && activePieces[pieceIndex])
        {
            ;
            Vector3 piecePosition = piece.GetComponent<RectTransform>().anchoredPosition;
            Vector3 targetPosition = positions[pieceIndex];
            return Mathf.Abs(piecePosition.x - targetPosition.x) <= toleranceValue && Mathf.Abs(piecePosition.y - targetPosition.y) <= toleranceValue;
        }
        else
        {
            return false;
        }
    }

    void SetCorrectPiece(GameObject piece)
    {
        int pieceIndex = System.Array.IndexOf(pieces, piece);
        Vector3 position = positions[pieceIndex];
        piece.GetComponent<RectTransform>().anchoredPosition = position;
        activePieces[pieceIndex] = false;
    }

    bool CheckFinishPuzzle()
    {
        bool result = true;
        foreach (bool active in  activePieces)
        {
            if (active)
            {
                result = false;
                break;
            }
        }
        return result;
    }

    void MixPieces()
    {
        foreach(GameObject piece in pieces)
        {
            piece.GetComponent<RectTransform>().anchoredPosition = new Vector3(Random.Range(-horizontalRange, horizontalRange), Random.Range(-verticalRange, verticalRange), 0);
        }
    }

    public void StartPuzzle()
    {
        this.gameObject.SetActive(true);
        MixPieces();
    }

    void FinishPuzzle()
    {
        this.gameObject.SetActive(false);
    }

}
