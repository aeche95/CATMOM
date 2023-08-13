using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacion : MonoBehaviour
{

    [SerializeField]
    Animator animator;

    [SerializeField]
    string endAnimationTrigger;

    [SerializeField]
    string startAnimationTrigger;

    [SerializeField]
    GameObject gameManager;

    GameManager gameManagerInstance;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        gameManagerInstance = gameManager.GetComponent<GameManager>();
    }

    public void StartAnimation()
    {
        animator.SetTrigger(startAnimationTrigger);
    }

    public void EndAnimation()
    {
        animator.SetTrigger(endAnimationTrigger);
    }
    void TellGameManagetToPassTime()
    {
        gameManagerInstance.SetAbandoned(true);
    }
}
