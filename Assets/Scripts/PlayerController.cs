using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager gameManager;
    private Targets[] targets;
    private int currentTargetIndex = 0;

    [SerializeField] private Camera playerCamera;
    [SerializeField] private LayerMask obstacleLayer;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
